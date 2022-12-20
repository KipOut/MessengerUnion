const Router = require('express');
const router = new Router()
const userController = require('../controller/user.controller')

router.post('/checkConnect', userController.checkOnline)
router.post('/signUpUser', userController.signUpUser)
router.post('/signInUser', userController.signInUser)
router.get('/connect', userController.connect)
router.get('/userName/:email', userController.dataUserName)
router.get('/allUsers', userController.dataAllUsersName)
router.get('/numberOfUsers', userController.numberOfUsersName)
router.delete('/userData/:id', userController.deleteUser)

module.exports = router