App.SalesAgentsRoute = Ember.Route.extend({
	model: function() {
		return App.SalesAgent.find();
	}
});

App.SalesAgentsIndexRoute = Ember.Route.extend({
	model: function () { return this.modelFor('salesAgents'); }
});

App.SalesAgentsDetailRoute = Ember.Route.extend({
	model: function(params) {
		return App.SalesAgent.findById(params.id);
	}
});
