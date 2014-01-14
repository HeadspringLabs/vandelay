App.LocationsRoute = Ember.Route.extend({
	model: function() {
		return App.Location.find();
	}
});
