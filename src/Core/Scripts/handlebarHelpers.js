Ember.Handlebars.helper('dollars', function (amount) {
	if (isNaN(amount))
		amount = parseFloat(amount);

	amount = amount.toFixed(2);

	var withCommas = amount.toString()
		.replace(/\B(?=(\d{3})+(?!\d))/g, ","); //thanks, StackOverflow

	return '$' + withCommas;
});
