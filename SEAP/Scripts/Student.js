(function () {
	$(function () {
		var toggle;
		return toggle = new Toggle('.toggle');
	});

	this.Toggle = function () {
		class Toggle {
			constructor(toggleClass) {
				this.el = $(toggleClass);
				this.tabs = this.el.find(".tab");
				this.panels = this.el.find(".panel");
				this.bind();
			}

			show(index) {
				var activePanel, activeTab;
				//update tabs
				this.tabs.removeClass('active');
				activeTab = this.tabs.get(index);
				$(activeTab).addClass('active');
				//update panels
				this.panels.hide();
				activePanel = this.panels.get(index);
				return $(activePanel).show();
			}

			bind() {
				return this.tabs.unbind('click').bind('click', e => {
					return this.show($(e.currentTarget).index());
				});
			}
		}

		;

		Toggle.prototype.el = null;

		Toggle.prototype.tabs = null;

		Toggle.prototype.panels = null;

		return Toggle;

	}.call(this);

}).call(this);

//# sourceURL=coffeescript