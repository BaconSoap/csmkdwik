var mkdwiki;
(function(ns, $){
	
	ns.page = {};
	$(init);
	function init() {
		console.log('initialized');
		ns.page.title = window.location.pathname + window.location.search;
		bindCheckboxes();
	}

	function bindCheckboxes() {
		var wikiBoxes = $('input[type=checkbox][data-mkdwiki]');
		wikiBoxes.on('change', function(){
			updateCheckbox($(this).data('mkdwiki-id'), this.checked);
		});
	}

	function updateCheckbox(checkboxId, checked) {
		$.post(ns.page.path + '/checkbox/' + checkboxId, {isChecked: checked})
			.done(updateCheckboxSuccess)
			.fail(updateCheckboxFail);
	}

	function updateCheckboxSuccess(data) {
		console.log(data);
	}

	function updateCheckboxFail() {
		console.error(data);
	}

})(mkdwiki || (mkdwiki = {}), jQuery);