const db = require('../db')

class UserController {
    
    async signUpUser(req, res) {
        const { email, password, initials} = req.body
        const checkEmail = await db.query('SELECT EXISTS (SELECT * FROM users WHERE email = $1)', [email])
        const isRowExistsEmail = checkEmail.rows[0]
        if (!isRowExistsEmail.exists)
        {
            const newUser = await db.query('INSERT INTO users (email, password, initials) values ($1, $2, $3) RETURNING *', [email, password, initials])
            res.send('Вы зарегистрировались')
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