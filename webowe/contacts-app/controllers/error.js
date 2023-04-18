const YEAR = new Date().getFullYear();
exports.get404 = (error ,req, res, next) => {
	res.status(500).render('500', {
		pageTitle: "Error 500 - server error", 
		year: YEAR
	});
};

exports.get500 = (req, res, next) => {
	res.status(404).render('404', {
		pageTitle: "Error 404 - page not found", 
		year: YEAR
	});
};