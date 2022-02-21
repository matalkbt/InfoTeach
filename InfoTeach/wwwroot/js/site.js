/**
 * On page load, call controller for subjects
 **/
if (top.location.pathname === '/Lessons/MyLessons') {
    $(document).ready(function () {
        $.ajax({
            type: "GET",
            url: '/Lessons/MySubjects',
            success: function (data) {
                $('#subjects').html(data);
            }
        });
    });
}

function renderLessons(id) {
    $.ajax({
        type: "GET",
        url: '/Lessons/Lessons',
        data: { subjectId: id },
        success: function (data) {
            $('#lessons').html(data);
        }
    });
}

function renderAssignments(id) {
    $.ajax({
        type: "GET",
        url: '/Lessons/MyAssignments',
        data: { lessonId: id },
        success: function (data) {
            $('#assignments').html(data);
        }
    });
}

function loadAssignment(id) {
    $.ajax({
        type: "GET",
        url: '/Lessons/LoadAssignment',
        data: { assignmentId: id },
        success: function (data) {
            //Hide and disable nav
            $("#lessonsNav").attr('disabled', true);
            $("#lessonsNav").attr('hidden', true);

            //Load assignment HTML
            $("#assignmentContainer").html(data);
        }
    })
}

