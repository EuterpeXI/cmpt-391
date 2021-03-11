from random import *
import datetime

fNames = ["Taylor", "Jake", "Sam", "Logan", "Terry", "Jack", "Guy", "Ignore", "Placeholder", "Name", "Dani", "Becka",
          "Lucy", "Brandon", "Nicolas", "Chris", "Alex", "Amelia", "Timothy", "Chamod"]
lNames = ["Smith", "Bolas", "Grant", "Dougan", "Poirier", "Name", "Taylor", "Randall", "Estey", "Jackson", "Chin",
          "Kwan", "Butts", "Placeholder"]
city = ["Spruce", "Stony", "Edmonton", "Calgary",
        "Quebec City", "Vancouver", "Victoria", "Toronton"]
provinces = ["AB", "BC", "SK", "QB", "NT", "MT"]
country = ["CA", "US", "UK", "RU"]
building = ["Homer", "Flanders", "Marge", "Lisa", "Bart"]
room = ["11", "12", "13", "14", "21", "22", "23", "31", "32"]
depts = ["Biol", "Chem", "Phys", "Math", "Cmpt",
         "Hist", "Engl", "Anth", "Ling", "Stat", "Soci"]
terms = ["Fall", "Winter"]

days = ["mwf", "tth"]

mwf_timeslots = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10]
tth_timeslots = [1, 2, 3, 4, 5, 6]


def choose_random_characters(num, rand=True):
    return ''.join([choice("abcdefghijklmnopqrstuvwxyz") for i in range(randint(1, num) if rand else num)])


def choose_random_num(num, rand=True):
    return ''.join([choice("1234567890") for i in range(randint(1, 10) if rand else num)])


def choose_random_city():
    return city[randint(0, len(city) - 1)]


def choose_random_province():
    return provinces[randint(0, len(provinces) - 1)]


def choose_random_country():
    return country[randint(0, len(country) - 1)]


class Address:
    def __init__(self):
        self.nameS = ""
        self.numS = ""
        self.apt = ""
        self.city = ""
        self.province = ""
        self.country = ""
        self.zip = ""
        self.phone = ""
        self.make_address()

    def make_address(self):
        self.nameS = choose_random_characters(10)
        self.numS = choose_random_num(10)
        self.apt = choose_random_num(10) if randint(0, 1) == 1 else ""
        self.city = choose_random_city()
        self.province = provinces[randint(0, len(provinces) - 1)]
        self.country = choose_random_country()
        self.zip = ''.join([choice("ABCDEFGHIJKLMNOPQRSTUVWXYZ") if i % 2 == 0 else choice("1234567890")
                            for i in range(6)])
        self.phone = choose_random_num(10, False)

    def address_attributes(self):
        return_string = "street_name, street_number, " + \
                        "city, province, country, zip, phone_number"
        return return_string

    def address_string(self):
        return_string = "'" + self.nameS + "', '" + self.numS + "', '" + \
                        self.city + "', '" + self.province + "', '" + self.country \
                        + "', '" + self.zip + "', '" + self.phone + "'"
        return return_string


class Person(Address):
    def __init__(self):
        self.fName = ""
        self.lName = ""

        Address.__init__(self)
        self.make_person()

    def make_person(self):
        self.fName = fNames[randint(0, len(fNames) - 1)]
        self.lName = lNames[randint(0, len(lNames) - 1)]

    def person_attributes(self):
        return_string = "first_name, last_name"
        return return_string + ", " + self.address_attributes()

    def person_string(self):
        return_string = "'" + self.fName + "', '" + self.lName + "'"
        return return_string + ", " + self.address_string()


class Student(Person):
    count = 1111111111

    def __init__(self):
        Student.count += 1
        self.studID = str(Student.count)
        self.gender = list({"M", "F", "?"})[randint(0, 2)]
        self.classes = []
        Person.__init__(self)

    def get_id(self):
        return self.studID

    def student_attributes(self):
        return_string = "s_id, gender, sin, email, street_address, date_of_birth"
        return return_string + ", " + self.person_attributes()

    def student_string(self):
        return_string = "" + self.studID + ", '" + self.gender + "', '123456789', '" + \
            str(self.studID) + "@" + "wacewan.org', 'placeholder', '01/01/0001'"
        return return_string + ", " + self.person_string()

    def add_class(self, class_added):
        if len(self.classes) < 1:
            self.classes.append(class_added)
        else:
            for c in self.classes:
                if c.day != class_added.day or c.timeslot != class_added.timeslot:
                    self.classes.append(class_added)
                    break

    def get_takes(self):
        return [Takes(self, c.c_id) for c in self.classes]

    def get_courses(self):
        return self.classes


class Prof(Person):
    count = 111111111

    def __init__(self, department):
        Prof.count += 1
        self.profID = str(Prof.count)
        self.dept = department
        self.salary = randint(1, 12) * 10000
        Person.__init__(self)

    def get_PID(self):
        return self.profID

    def prof_attributes(self):
        return_string = "i_id, dept, salary, first_name, last_name"
        return return_string

    def prof_string(self):
        return_string = "" + self.profID + ", '" + self.dept + "', " + str(self.salary) + ", '" +\
            self.fName + "', '" + self.lName + "'"
        return return_string


class Department:

    def __init__(self, dept_name):
        self.name = dept_name
        self.head = ""
        self.building = building[randint(0, len(building) - 1)]
        self.room = room[randint(0, len(room) - 1)]
        self.profs = []
        self.courses = []

    def set_head(self):
        self.head = self.profs[randint(0, len(self.profs) - 1)].get_PID()

    def dept_attributes(self):
        return_string = "name, building, room"
        return return_string

    def dept_string(self):
        return_string = "'" + self.name + "', '" + \
            self.building + "', '" + self.room + "'"
        return return_string

    def add_prof(self, prof):
        self.profs.append(prof)

    def add_course(self):
        self.courses.append(Course(self.name))

    def get_courses(self):
        return self.courses

    def get_rand_inst(self):
        return self.profs[randint(0, len(self.profs)-1)]


class Course:
    count = 1111

    def __init__(self, department):
        Course.count += 1
        self.CID = str(Course.count)
        self.title = choose_random_characters(10)
        self.dept = department
        self.sections = []

    def course_attributes(self):
        return_string = "c_id, title, credit, term, department"
        return return_string

    def course_string(self):
        return_string = "" + self.CID + ", '" + \
            self.title + "', 3, 'Fall', '" + self.dept + "'"
        return return_string

    def get_CID(self):
        return self.CID


class Section:
    count = 1

    def __init__(self, instructor, course):
        Section.count += 1
        self.sect_id = str(Section.count)
        self.inst  = instructor
        self.year  = 2021
        self.term  = "Fall"
        self.room  = "111"
        self.c_id  = course
        self.limit = randint(30, 100)
        self.enrolled = 0

        day_poss = randint(0, 1)
        self.timeslot = mwf_timeslots[randint(0, len(
            mwf_timeslots)-1)] if day_poss == 0 else tth_timeslots[randint(0, len(tth_timeslots)-1)]
        self.day = days[day_poss]
        time = 7 + self.timeslot

        self.start_time = datetime.datetime.strptime(
            str(time) + ":00", "%H:%M")
        self.end_time = datetime.datetime.strptime(
            str(time + 1) + ":00", "%H:%M")

    def get_cid(self):
        return self.c_id

    def course_attributes(self):
        return_string = "section_id, year, term, start_time, end_time, days, room_number, instructor, course, student_limit"
        return return_string

    def course_string(self):
        return_string = "" + self.sect_id + ", '" + str(self.year) + "', '" + self.term + "', '" +\
            str(self.start_time) + "', '" + str(self.end_time) + "', '" + self.day + "', '" + self.room + "', '" +\
            self.inst + "', " + str(self.c_id) + ", " + str(self.limit)

        return return_string

    def not_full(self):
        return self.enrolled < self.limit
    def increment_enroll(self):
        self.enrolled += 1
    def set_term(self, new_term):
        self.term = new_term


class Prereqs:

    def __init__(self, c1, c2):
        self.course = c1.get_CID()
        self.prereq = c2.get_CID()

    def pre_attributes(self):
        return_string = "c_id, p_id"
        return return_string

    def pre_string(self):
        return_string = "'" + self.course + "', '" + self.prereq + "'"
        return return_string

    def get_related(self, cid):
        if cid == self.prereq:
            return self.course
        if cid == self.course:
            return self.prereq
        return cid




class Takes:

    def __init__(self, student, section):
        self.student = student.get_id()
        self.course = section

    def take_attributes(self):
        return_string = "s_id, c_id"
        return return_string

    def take_string(self):
        return_string = "" + self.student + ", " + self.course + ""
        return return_string


def framing(table, attributes, values):
    command = "INSERT INTO " + table + " (" + attributes + ")\n" \
              + "VALUES (" + values + ")"
    return command


open('query_file.sql', 'w').close()
my_file = open("query_file.sql", "w+")

# make departments
departments = []
for dept_name in depts:
    departments.append(Department(dept_name))
    my_file.write(framing(
        "department", departments[-1].dept_attributes(), departments[-1].dept_string()) + "\n")

# make profs
for indi_dept in departments:
    profs_in = randint(10, 20)
    for i in range(profs_in):
        new_prof = Prof(indi_dept.name)
        indi_dept.add_prof(new_prof)
        my_file.write(framing(
            "instructor", new_prof.prof_attributes(), new_prof.prof_string()) + "\n")
    # assign head
    indi_dept.set_head()

# make students
students = []
student_count = randint(10000, 15000)
for i in range(student_count):
    students.append(Student())
    my_file.write(framing(
        "student", students[-1].student_attributes(), students[-1].student_string()) + "\n")

# make courses
for indi_dept in departments:
    cor_num = randint(10, 15)
    for i in range(cor_num):
        indi_dept.add_course()
        my_file.write(framing(
            "course", indi_dept.courses[-1].course_attributes(), indi_dept.courses[-1].course_string()) + "\n")
        # add course pre req
        if i > 5:
            prereqs = []
            num_prereqs = randint(0, 2)
            for i in range(num_prereqs):
                prereqs.append(Prereqs(
                    indi_dept.courses[-1], indi_dept.courses[randint(0, len(indi_dept.courses)-2)]))
                my_file.write(framing(
                    "prereq", prereqs[-1].pre_attributes(), prereqs[-1].pre_string()) + "\n")


# make sections for year
fall_sections = []
for indi_dept in departments:
    for course in indi_dept.get_courses():
        z = randint(1, 4)
        cor_sec = []
        for i in range(z):
            # assign profs to sections
            inst = indi_dept.get_rand_inst().profID
            cor_sec.append(Section(inst, course.CID))
        fall_sections.append(cor_sec)
        for sect in cor_sec:
            my_file.write(
                framing("section", sect.course_attributes(), sect.course_string()) + "\n")

# create and print the winter courses available
winter_sections = []
for indi_dept in departments:
    for course in indi_dept.get_courses():
        z = randint(1, 4)
        cor_sec = []
        for i in range(z):
            # assign profs to sections
            inst = indi_dept.get_rand_inst().profID
            new_sect = Section(inst, course.CID)
            new_sect.set_term("Winter")
            cor_sec.append(new_sect)
        winter_sections += cor_sec
        for sect in cor_sec:
            my_file.write(
                framing("section", sect.course_attributes(), sect.course_string()) + "\n")

# give students classes, up to 5 but at least 1, , make sure students aren't taking a course and its prereq
for stud in students:
    i = 0
    num_courses = randint(1, 6)
    poss_classes = [i for i in range(len(fall_sections) - 1)]
    shuffle(poss_classes)
    while i < num_courses and len(poss_classes) > 1:
        class_num = poss_classes.pop()
        taking_req = False
        for req in prereqs:
            requisite = req.get_related(fall_sections[class_num][0].get_cid())

            for c in stud.get_courses():
                if c == requisite:
                    taking_req = True

        a = randint(0, len(fall_sections[class_num]) - 1)
        b = abs((a - 1)% len(fall_sections[class_num]))
        while not fall_sections[class_num][a].not_full() and a != b:
            a = (a+1)% len(fall_sections[class_num])
        if not taking_req and a != b:
            fall_sections[class_num][a].increment_enroll()
            stud.add_class(fall_sections[class_num][a])
            i += 1

takes = []
for stud in students:
    #takes.append(stud.get_takes())
    for take in stud.get_takes():
        my_file.write(framing("takes", take.take_attributes(),
                              take.take_string()) + "\n")

my_file.close()

# start with just the one year
