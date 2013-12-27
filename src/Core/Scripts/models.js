var attr = Ember.attr;

App.Location = Ember.Model.extend({
	id: attr(),
	name: attr(),
	address: attr()
});

App.Location.url = "/api/location/";
App.Location.adapter = App.Adapter.create();
