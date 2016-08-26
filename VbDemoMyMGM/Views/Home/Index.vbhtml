@Code
    ViewData("Title") = "MyMGM Events"
End Code

@Section Scripts
    @Scripts.Render("~/bundles/bootstrapdatetimepicker")
    @Scripts.Render("~/bundles/kendocore")
End Section

<div class="jumbotron">
    <h1>Montgomery Events</h1>
    <p class="lead">Montgomery has a variety of interesting events. Browse them below or submit your own.</p>
</div>

<div class="row">
    <h2>Upcoming events</h2>

    <div id="listView"></div>
    <!--<div id="pager" class="k-pager-wrap"></div>-->

    <script type="text/x-kendo-template" id="template">
        <div class="event">
            <div style="float:right;">
                <a href="#:Url#" target="_blank">
                    <img src="http://webthumbnail.org/api/?width=250&height=250&screen=1280&url=#:Url#"
                         width="250" height="250" />
                </a>
            </div>
            <h3><a href="#:Url#" target="_blank">#:Title#</a></h3>
            <p>#:Description#</p>
            <p>Date: #:StartDate#</p>
            <div style="clear:both"></div>
        </div>
    </script>

    <script>
        $(function () {
            var dataSource = new kendo.data.DataSource({
                sort: { field: "StartDate", dir: "asc" },
                schema: {
                    model: {
                        fields: {
                            Title: { type: "string" },
                            StartDate: { type: "date" }
                        }
                    }
                },
                transport: {
                    read: {
                        url: "/api/localeventsapi",
                        dataType: "json"
                    }
                } //,
                // pageSize: 21
            });
            /*
                $("#pager").kendoPager({
                    dataSource: dataSource
                });
                */
            $("#listView").kendoListView({
                dataSource: dataSource,
                template: kendo.template($("#template").html())
            });
        });
    </script>


</div>

