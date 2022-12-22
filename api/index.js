const express = require('express')
const userRouter = require('./routes/user.routes')
const port = process.env.PORT || 8080
const app = express()

app.use(express.json())
app.use('/union', userRouter)

app.listen(port, () => console.log(port))

