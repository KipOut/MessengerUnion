const db = require('../db')

const hbs = require('nodemailer-express-handlebars')
const nodemailer = require('nodemailer')
const path = require('path')

function randomIntFromInterval(min, max) { 
    return Math.floor(Math.random() * (max - min + 1) + min)
  }
 let codeSecret = randomIntFromInterval(100000, 999999)

const transporter = nodemailer.createTransport({
            host: 'Gmail',
            port: 465,
            service:'gmail',
            secure: false,
            auth: {
               user: 'dadaa3361@gmail.com',
               pass: 'nfxkilyoaczlgrdc'
            },
            debug: false,
            logger: true
});
const handlebarOptions = {
    viewEngine: {
        partialsDir: path.resolve('controller'),
        defaultLayout: false,
    },
    viewPath: path.resolve('controller'),
};
transporter.use('compile', hbs(handlebarOptions))



class UserController {
    
    async signUpUser(req, res) {
        const { email, password, initials} = req.body
        const code = req.params.code
        const checkEmail = await db.query('SELECT EXISTS (SELECT * FROM users WHERE email = $1)', [email])
        const isRowExistsEmail = checkEmail.rows[0]
        if (!isRowExistsEmail.exists)
        {
            var mailOptions = {
                from: '"unionBot" <dadaa3361@gmail.com>',
                to: email, 
                subject: 'Подтвердите e-mail',
                template: 'email',
                context:{
                    initials: initials,
                    code: codeSecret
                }
            };
            transporter.sendMail(mailOptions, function(error, info){
                if(error){
                    return console.log(error);
                }
            });
            if (code == codeSecret){
                const newUser = await db.query('INSERT INTO users (email, password, initials) values ($1, $2, $3) RETURNING *', [email, password, initials])
                res.send('Вы зарегистрировались')
            }
            else res.send('Введите код')
        }
        else res.send('Почта уже используется')
    }

    async signInUser(req, res) {
        const { email, password } = req.body
        
        const checkEmail = await db.query('SELECT EXISTS (SELECT * FROM users WHERE email = $1)', [email])
        const checkPassword = await db.query('SELECT EXISTS (SELECT * FROM users WHERE password = $1)', [password])

        const isRowExistsEmail = checkEmail.rows[0]
        const isRowExistsPassword = checkPassword.rows[0]
        
        if (isRowExistsEmail.exists && isRowExistsPassword.exists) res.send('Вы вошли')
        else res.send('Ошибка: неверный логин или пароль')
    }

    async dataUserName(req, res){
        const email = req.params.email
        const user = await db.query('SELECT initials FROM users WHERE email = $1', [email])
        res.send(user.rows[0].initials)
    }

    async dataAllUsersName(req, res){
        const usersData = await db.query('select initials from users')
        res.send(usersData.rows)
    }
    async numberOfUsersName(req, res){
        const number = await db.query('select initials from users')
        res.json(number.rowCount)
    }

    async connect(req, res){
        res.send('Online')
    }

    async checkOnline(req, res){
        res.send('Online')
    }

    async deleteUser(req, res){
        const id = req.params.id
        const user = await db.query('DELETE FROM users WHERE id = $1', [id])
    }
}
//http://localhost:8080/union/userData
module.exports = new UserController()