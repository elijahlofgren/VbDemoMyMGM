<!DOCTYPE html>
<html lang="en" ng-app="myApp">
<head>
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>@ViewBag.Title - MyMGM</title>
    @Styles.Render("~/Content/css")
    <!-- kendo css -->
    @*@Styles.Render("~/Content/kendocss")*@
    @Scripts.Render("~/bundles/modernizr")
    <link rel="stylesheet" href="/app/bower_components/html5-boilerplate/dist/css/normalize.css">
    <link rel="stylesheet" href="/app/bower_components/html5-boilerplate/dist/css/main.css">
    <link rel="stylesheet" href="/app/app.css">
    <script src="/app/bower_components/html5-boilerplate/dist/js/vendor/modernizr-2.8.3.min.js"></script>
</head>
<body>
    @Scripts.Render("~/bundles/jquery")
    @Scripts.Render("~/bundles/bootstrap")
    @RenderSection("scripts", required:=False)

    <div class="navbar navbar-inverse navbar-fixed-top">
        <div class="container">
            <div class="navbar-header">
                <button type="button" class="navbar-toggle" data-toggle="collapse" data-target=".navbar-collapse">
                    <span class="icon-bar"></span>
                    <span class="icon-bar"></span>
                    <span class="icon-bar"></span>
                </button>
                @Html.ActionLink("MyMGM", "Index", "Home", New With {.area = ""}, New With {.class = "navbar-brand"})
            </div>
            <div class="navbar-collapse collapse">
                <ul class="nav navbar-nav">
                    <li>@Html.ActionLink("Home", "Index", "Home")</li>
                    <li>@Html.ActionLink("About", "About", "Home")</li>
                    <li>@Html.ActionLink("Contact", "Contact", "Home")</li>
                </ul>
                @Html.Partial("_LoginPartial")
            </div>
        </div>
    </div>
    <div class="container body-content">
        @RenderBody()
        <hr />
        <footer>
            <p>Made with <span style="color:red">&hearts;</span> in Montgomery, AL by <a href="http://twitter.com/elijahlofgren" target="_blank">Elijah Lofgren</a></p>
        </footer>
    </div>


</body>
</html>
