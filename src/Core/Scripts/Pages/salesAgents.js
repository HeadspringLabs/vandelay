App.SalesAgentsRoute = Ember.Route.extend({
	model: function() {
		return App.SalesAgent.find();
	}
});


App.SalesAgentsController = Ember.ArrayController.extend({
	
});

App.SalesAgentController = Ember.ObjectController.extend({
	
});