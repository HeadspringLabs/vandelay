var attr = Ember.attr;

App.Location = Ember.Model.extend({
	id: attr(),
	name: attr(),
	address: attr()
});

App.Location.url = "/api/location/";
App.Location.adapter = App.Adapter.create();

App.SalesAgent = Ember.Model.extend({
	id: attr(),
	name: attr(),
	imageUrl: attr(),
	location: attr(),
	imports: attr(),
	exports: attr(),
});

App.SalesAgent.url = "/api/salesAgent/";
App.SalesAgent.adapter = App.Adapter.create();
