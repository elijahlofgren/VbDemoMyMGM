@Code
    ViewData("Title") = "MGM Events"
End Code

@Section Scripts
    @Scripts.Render("~/bundles/bootstrapdatetimepicker")
End Section




<div class="jumbotron">
    <h1>Montgomery Events</h1>
    <p class="lead">Montgomery has a variety of interesting events. Browse them below or submit your own.</p>
    <p><a href="http://asp.net" class="btn btn-primary btn-lg">Learn more &raquo;</a></p>
</div>

<div class="row">
    <div class="col-md-8">
        <h2>Submit a new event</h2>

        <div class="container">
            <div class="row">
                <div class='col-sm-6'>
                    <div class="form-group">
                        <div class='input-group date' id='datetimepicker1'>
                            <input type='text' class="form-control" />
                            <span class="input-group-addon">
                                <span class="glyphicon glyphicon-calendar"></span>
                            </span>
                        </div>
                    </div>
                </div>
                <script type="text/javascript">
                    $(function () {
                $('#datetimepicker1').datetimepicker();
            });
                </script>
            </div>
        </div>

        <div class="form-group row">
            <label for="example-text-input" class="col-xs-2 col-form-label">Title</label>
            <div class="col-xs-10">
                <input class="form-control" type="text" value="" id="event-title">
            </div>
        </div>
        <div class="form-group row">
            <label for="example-search-input" class="col-xs-2 col-form-label">URL</label>
            <div class="col-xs-10">
                <input class="form-control" type="search" value="" id="event-url">
            </div>
        </div>
        <div class="form-group row">
            <label for="example-email-input" class="col-xs-2 col-form-label">Description</label>
            <div class="col-xs-10">
                <textarea class="form-control" id="event-description">
                 </textarea>
            </div>
        </div>
        <div class="form-group row">
            <label for="example-url-input" class="col-xs-2 col-form-label">Start Date &Aacute; Time</label>
            <div class="col-xs-10">
                <input class="form-control" type="url" value="http://getbootstrap.com" id="example-url-input">
            </div>
        </div>
        <div class="form-group row">
            <label for="example-tel-input" class="col-xs-2 col-form-label">Telephone</label>
            <div class="col-xs-10">
                <input class="form-control" type="tel" value="1-(555)-555-5555" id="example-tel-input">
            </div>
        </div>
        <div class="form-group row">
            <label for="example-password-input" class="col-xs-2 col-form-label">Password</label>
            <div class="col-xs-10">
                <input class="form-control" type="password" value="hunter2" id="example-password-input">
            </div>
        </div>
        <div class="form-group row">
            <label for="example-number-input" class="col-xs-2 col-form-label">Number</label>
            <div class="col-xs-10">
                <input class="form-control" type="number" value="42" id="example-number-input">
            </div>
        </div>
        <div class="form-group row">
            <label for="example-datetime-local-input" class="col-xs-2 col-form-label">Date and time</label>
            <div class="col-xs-10">
                <input class="form-control" type="datetime-local" value="2011-08-19T13:45:00" id="example-datetime-local-input">
            </div>
        </div>
        <div class="form-group row">
            <label for="example-date-input" class="col-xs-2 col-form-label">Date</label>
            <div class="col-xs-10">
                <input class="form-control" type="date" value="2011-08-19" id="example-date-input">
            </div>
        </div>
        <div class="form-group row">
            <label for="example-month-input" class="col-xs-2 col-form-label">Month</label>
            <div class="col-xs-10">
                <input class="form-control" type="month" value="2011-08" id="example-month-input">
            </div>
        </div>
        <div class="form-group row">
            <label for="example-week-input" class="col-xs-2 col-form-label">Week</label>
            <div class="col-xs-10">
                <input class="form-control" type="week" value="2011-W33" id="example-week-input">
            </div>
        </div>
        <div class="form-group row">
            <label for="example-time-input" class="col-xs-2 col-form-label">Time</label>
            <div class="col-xs-10">
                <input class="form-control" type="time" value="13:45:00" id="example-time-input">
            </div>
        </div>
        <div class="form-group row">
            <label for="example-color-input" class="col-xs-2 col-form-label">Color</label>
            <div class="col-xs-10">
                <input class="form-control" type="color" value="#563d7c" id="example-color-input">
            </div>
        </div>
    </div>
    <div class="col-md-4">
        <h2>Upcoming events</h2>
        <p>NuGet is a free Visual Studio extension that makes it easy to add, remove, and update libraries and tools in Visual Studio projects.</p>
        <p><a class="btn btn-default" href="http://go.microsoft.com/fwlink/?LinkId=301866">Learn more &raquo;</a></p>
    </div>
</div>
