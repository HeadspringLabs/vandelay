App.SalesAgentsRoute = Ember.Route.extend({
	model: function() {
		return App.SalesAgent.find();
	}
});

App.SalesAgentRoute = Ember.Route.extend({
	model: function(params) {
		return App.SalesAgent.findById(params.id);
	}
});

App.SalesAgentsController = Ember.ArrayController.extend({
	
});

App.SalesAgentController = Ember.ObjectController.extend({
	
});