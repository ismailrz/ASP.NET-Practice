Create DataBase University;
use University;


Create table ClassRooms(
building varchar(15),
room_number varchar(7),
capacity numeric (4,0),
primary key (building, room_number)
);

create table Departments(
dept_name varchar(20),
building varchar(15),
budget  numeric (12,2) check (budget > 0),
primary key (dept_name)
);

create table Courses (
course_id varchar(8),
title	  varchar(50),
dept_name varchar(20),
credits numeric(2,0) check (credits > 0),
primary key (course_id),
foreign key(dept_name) references Departments
on delete set null
);


create table Instructors(
ID     varchar(5),
name   varchar(20) not null,
dept_name varchar(20),
salary numeric(8,2) check (salary >29000),
primary key (ID),
foreign key(dept_name) references Departments
on delete set null
);

create table Sections(
	course_id varchar(8),
	sec_id  varchar(8),
	semester varchar(6) check (semester in  ('Fall', 'Winter', 'Spring', 'summer')),
	year     numeric(4,0) check (year > 2000 and year <2100),
	building varchar(15),
	room_number varchar(7),
	time_slot_id varchar(4),
	primary key (course_id, sec_id, semester, year),
	foreign key (course_id) references Courses on delete cascade,
	foreign key (building, room_number) references ClassRooms on delete set null
);

create table Teaches (
ID varchar(5),
course_id varchar(8),
sec_id varchar(8),
semester varchar(6),
year numeric(4,0),
primary key(ID, course_id, sec_id, semester, year),
foreign key(course_id, sec_id, semester, year) references Sections on delete cascade,
foreign key(ID) references Instructors on delete cascade
);

create table Students (
ID varchar(5),
name varchar(20),
dept_name varchar(20),
tot_cred  numeric(3,0) check (tot_cred >0),
primary key(ID),
foreign key(dept_name) references Departments on delete set null
);

create table Takes(
ID varchar(5),
course_id varchar(8),
sec_id varchar(8),
semester varchar(6),
year numeric(4,0),
grade varchar(2),
primary key(ID, course_id, sec_id, semester, year),
foreign key(course_id, sec_id, semester, year ) references Sections on delete cascade,
foreign key(ID) references Students on delete cascade
);

create table Advisors (
s_ID varchar(5),
i_ID varchar(5),
primary key(s_ID),
foreign key(i_ID) references Instructors(ID) on delete set null,
foreign key(s_ID) references Students(ID) on delete cascade
);

create table prereqs(
course_id varchar(8),
prereq_id varchar(8),
primary key(course_id, prereq_id),
foreign key(course_id) references Courses on delete cascade,
foreign key(prereq_id) references Courses
);

create table timeslots(
time_slot_id varchar(4),
day varchar(1) check(day in ('M','T','W''R','F','S','U')),
start_time time,
end_time  time,
primary key(time_slot_id, day, start_time)
);


INSERT INTO Departments VALUES('CSE','Academic I',5000000)
SELECT dept_name FROM Departments;
SELECT dept_name FROM Departments where dept_name ='EEE';



Insert INTO ClassRooms VALUES('Academic','AC-3',50);
SELECT * FROM CLassRooms;
SELECT * FROM ClassRooms WHERE building='Academic' AND room_number ='AC-3';


INSERT INTO Courses VALUES('ab-11','English','ECE',5);
SELECT * FROM Courses;
SELECT * FROM Courses WHERE course_id = 'ab-12';


INSERT INTO Instructors VALUES('12','Ismail','CSE',50000);
SELECT * FROM Instructors;
SELECT * FROM Instructors WHERE ID = '12';

INSERT INTO Students VALUES('12','Ismail','CSE',50);
SELECT * FROM Students;
SELECT * FROM Students WHERE ID = '12';

INSERT INTO Sections VALUES('ab-11','sec32','Spring',2022,'Academic','AC-3','m');

SELECT * FROM Sections;
SELECT * FROM Sections WHERE course_id ='ab-11' AND sec_id ='sec12' AND semester = 'Fall' AND year =2020;

INSERT INTO Takes VALUES('43','ab-11','sec12','Fall',2020,'B+');
SELECT * FROM Takes;
SELECT * FROM Takes WHERE ID ='12' AND course_id ='ab-11' AND sec_id ='sec12' AND semester = 'Fall' AND year =2020;


INSERT INTO Teaches VALUES('23','CSE101','434','Spring',2022);
SELECT * FROM Teaches;
SELECT * FROM Teaches WHERE ID ='12' AND course_id ='ab-11' AND sec_id ='sec12' AND semester = 'Fall' AND year =2020;

INSERT INTO Advisors VALUES('12','12');
SELECT * FROM Advisors;
SELECT * FROM Advisors WHERE s_ID = '12';

INSERT INTO prereqs VALUES('ab-11','ab-12');
SELECT * FROM prereqs;
SELECT * FROM prereqs WHERE course_id = 'ab-11' AND prereq_id = 'ab-12';



