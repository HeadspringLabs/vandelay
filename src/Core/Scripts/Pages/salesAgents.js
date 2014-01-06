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

App.SalesAgentsDetailController = Ember.ObjectController.extend({
	netImports: function () {
		var sum = 0;
		var imports = this.get('imports');
		$(imports).each(function(index, imp) {
			sum += (imp.price * imp.quantity);
		});
		return sum;
	}.property('model.imports'),
	netExports: function(){
		var sum = 0;
		var exports = this.get('exports');
		$(exports).each(function (index, exp) {
			sum += (exp.price * exp.quantity);
		});
		return sum;
	}.property('model.exports')
});
