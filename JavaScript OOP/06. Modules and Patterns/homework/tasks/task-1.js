/* Task Description */
/* 
 * Create a module for a Telerik Academy course
 * The course has a title and presentations
 * Each presentation also has a title
 * There is a homework for each presentation
 * There is a set of students listed for the course
 * Each student has firstname, lastname and an ID
 * IDs must be unique integer numbers which are at least 1
 * Each student can submit a homework for each presentation in the course
 * Create method init
 * Accepts a string - course title
 * Accepts an array of strings - presentation titles
 * Throws if there is an invalid title
 * Titles do not start or end with spaces
 * Titles do not have consecutive spaces
 * Titles have at least one character
 * Throws if there are no presentations
 * Create method addStudent which lists a student for the course
 * Accepts a string in the format 'Firstname Lastname'
 * Throws if any of the names are not valid
 * Names start with an upper case letter
 * All other symbols in the name (if any) are lowercase letters
 * Generates a unique student ID and returns it
 * Create method getAllStudents that returns an array of students in the format:
 * {firstname: 'string', lastname: 'string', id: StudentID}
 * Create method submitHomework
 * Accepts studentID and homeworkID
 * homeworkID 1 is for the first presentation
 * homeworkID 2 is for the second one
 * ...
 * Throws if any of the IDs are invalid
 * Create method pushExamResults
 * Accepts an array of items in the format {StudentID: ..., Score: ...}
 * StudentIDs which are not listed get 0 points
 * Throw if there is an invalid StudentID
 * Throw if same StudentID is given more than once ( he tried to cheat (: )
 * Throw if Score is not a number
 * Create method getTopStudents which returns an array of the top 10 performing students
 * Array must be sorted from best to worst
 * If there are less than 10, return them all
 * The final score that is used to calculate the top performing students is done as follows:
 * 75% of the exam result
 * 25% the submitted homework (count of submitted homeworks / count of all homeworks) for the course
 */

function solve() {
    function isInvalidTitle(title) {
        if (title.trim() != title || title.length < 1 || title == '' || title.trim().match(/\s{2,}/)) {
            return true;
        }else {
            return false;
        }
    }

    function isInvalidName(name) {
        if (/[A-Z]/g.test(name[0])) {
            return false;
        } else {
            return true;
        }
    }

    function isValidID(ID) {
        if (isNaN(ID) || ID < 1 || ID > studentIDs || (ID !== (ID | 0))) {
            return false;
        }
        return true;
    }

    var Course = {
        init: function (title, presentations) {
            if (isInvalidTitle(title)) {
                throw new Error();
            }
            if (presentations.length < 1) {
                throw new Error();
            }
            this.students = [];
            presentations.forEach(function (presentation) {
                if (isInvalidTitle(presentation)) {
                    throw new Error();
                }
                if (presentation.trim() !== presentation) {
                    throw new Error();
                }
                this.title = title;
                this.presentations = presentation;
                studentIDs = 0;
            })
            return this;
        },
        addStudent: function (name) {
            var firstName = name.split(' ')[0];
            var lastName = name.split(' ')[1];
            var moreThanTwoNames = name.split(' ')[2];
            if (isInvalidName(firstName) || isInvalidName(lastName)) {
                throw new Error();
            }
            if (moreThanTwoNames) {
                throw new Error();
            }
            studentIDs += 1;
            this.students.push({
                firstname: firstName,
                lastname: lastName,
                id: studentIDs
            });
            return studentIDs;
        },
        getAllStudents: function () {
            return this.students;
        },
        submitHomework: function (studentID, homeworkID) {
            if (!isValidID(studentID)) {
                throw new Error();
            }
            if (!isValidID(homeworkID)) {
                throw new Error();
            }
        },
        pushExamResults: function (results) {
        },
        getTopStudents: function () {
        }
    };

    return Course;
}


module.exports = solve;
