@Code
    ViewData("Title") = "Montgomery, AL Events"
End Code

@*@Section Scripts
    @Scripts.Render("~/bundles/bootstrapdatetimepicker")
End Section*@

<div class="jumbotron">
    <h1>Montgomery Events</h1>
    <p class="lead">Montgomery has a variety of interesting events. Browse them below or submit your own (coming soon).</p>
</div>
@*<ul class="menu">
    <li><a href="#!/view1">view1</a></li>
    <li><a href="#!/view2">view2</a></li>
</ul>*@
<!--[if lt IE 7]>
    <p class="browsehappy">You are using an <strong>outdated</strong> browser. Please <a href="http://browsehappy.com/">upgrade your browser</a> to improve your experience.</p>
<![endif]-->
<div ng-view></div>
@*<div>Angular seed app: v<span app-version></span></div>*@
<!-- In production use:
<script src="//ajax.googleapis.com/ajax/libs/angularjs/x.x.x/angular.min.js"></script>
-->
<script src="/app/bower_components/angular/angular.js"></script>
<script src="/app/bower_components/angular-route/angular-route.js"></script>
<script src="/app/bower_components/angular-sanitize/angular-sanitize.min.js"></script>
<script src="/app/bower_components/lodash/dist/lodash.min.js"></script>
<script src="/app/bower_components/restangular/dist/restangular.min.js"></script>

<script src="/app/app.js"></script>
<script src="/app/data/local_event.service.js"></script>
<script src="/app/home/home.controller.js"></script>
<script src="/app/view1/view1.js"></script>
<script src="/app/view2/view2.js"></script>
<script src="/app/components/version/version.js"></script>
<script src="/app/components/version/version-directive.js"></script>
<script src="/app/components/version/interpolate-filter.js"></script>
