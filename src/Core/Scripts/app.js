App = Ember.Application.create();

App.Adapter = Ember.RESTAdapter.extend({
	buildURL: function (record, suffix) {
		var s = this._super(record, suffix);
		return s.substring(0, s.length - 5);
	},
	ajaxSettings: function (url, method) {
		return {
			url: url,
			type: method
		};
	}
});

App.Router.map(function () {
	this.route("locations");
	this.route("salesAgents");
	this.resource("salesAgent", {path:"/salesAgents/:id"});
});
