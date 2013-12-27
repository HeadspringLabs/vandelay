App.SalesAgentsRoute = Ember.Route.extend({
	model: function() {
		return App.SalesAgent.find();
	}
});
