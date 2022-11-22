const express = require('express');
const router = express.Router();

let employees = [];

router.get('/', (req, res, next)=>{
    res.render('index', {
        pageTitle: "Lista pracowników",
        employees: employees,
    });
})

router.get('/about', (req, res, next)=>{
    res.render('about', {
        pageTitle: "O nas",
    });
})

router.post('/', (req, res, next)=> {
    const firstname = req.body.firstname;
    const lastname = req.body.lastname;
    const department = req.body.department;

    employees.push({
        id: Date.now(),
        firstname: firstname, 
        lastname: lastname,
        department: department,
    })
    console.log(employees);
    res.redirect('/');
})

module.exports = router;