drop table StoreOfDataPerForm;
drop table FormsCommunicationHierarchy;
drop table ProceedingDecisions;
drop table SodForms;
drop table SodUsersPriviledges;
drop table SodUSers;;
drop table SodDefinitionRoot;
drop table SodFormElementChoice;
drop table DbColumnTypes;
drop table SodTemplates;
drop table Priviledges;
drop table UsersTypes;
drop table SystemUsers;

create table SystemUsers
(
	Id int identity primary key,
	Name text,
	Login text,
	Password text,
	Email text,
	Phone text
);

create table UsersTypes
(
	Id int identity primary key,
	Type text
);

create table Priviledges
(
	Id int identity primary key,
	PriviledgeName text,
	Metadata text
);

create table SodTemplates 
(
	Id int identity primary key,
	Name text,
	Description text
);

create table DbColumnTypes
(
	Id int identity primary key,
	Name text,
	Description text
);	

create table SodFormElementChoice
(
	Id int identity primary key,
	ElementKind text,
	Metadata text

);	

create table SodDefinitionRoot
(
	Id int identity primary key,
	Name text,
	Description text
);	

create table SodUsers
(
	Id int identity primary key,
	IdSystemUsers int references SystemUsers(Id),
	IdUsersTypes int references UsersTypes(Id)
);

create table SodUsersPriviledges
(
	Id int identity primary key,
	IdSodUsers int references SodUsers(Id),
	IdPriviledges int references Priviledges(Id)
);

create table SodForms
(
	Id int identity primary key,
	IdSodDefinitionRoot int references SodDefinitionRoot(Id),
	IdSodFormElementChoice int references SodFormElementChoice(Id),
	IdDbColumnTypes int references DbColumnTypes(Id),
	IdPriviledges int references Priviledges(Id),
	IdPriviledgesSupervisor int references Priviledges(Id), --FormsCommunicationHierarchy dependent
	IdProceedingDecisions int,
	Comment text,
	Metadata text,
	Value  text
);	

create table ProceedingDecisions
(
	Id int identity primary key,
	IdPriviledges int references Priviledges(Id),
	IdSodUsersPriviledges int references SodUsersPriviledges(Id),
	IdSodForms int references SodForms(Id),
	Decision int
);

create table FormsCommunicationHierarchy
(
	Id int identity primary key,
	IdSodForms int references SodForms(Id),
	IdSodFormsChild int references SodForms(Id),
	IdSodDefinitionRoot int references SodDefinitionRoot(Id), --primary key
	IdSodDefinitionRootChild int references SodDefinitionRoot(Id), --foreign key
	CustomLogic text
);	

create table StoreOfDataPerForm
(
	Id int identity primary key,
	IdSodForms int references SodForms(Id),
	Data text, --sod doc
	Metadata text,
	Document text --base64 - pdf, docx, png, jpg, txt, plain text, etc
);	

