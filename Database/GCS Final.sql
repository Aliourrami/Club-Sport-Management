create database club_sport_2
use club_sport_2


--table SALLE--
SELECT        Planifier.NumS, Planifier.CodeAct, Planifier.Groupe, Salle.NumS AS Expr1, Groupe.CodeG, Entraineur.NumE, Activite.CodeAct AS Expr2, Adherent.NumA, paiment.CodeAb, paiment.NumA AS Expr3, Abonner.codeAb AS Expr4, 
                         Type_abonnement.CodeTAb
FROM            Abonner INNER JOIN
                         Adherent ON Abonner.NumA = Adherent.NumA INNER JOIN
                         Activite ON Adherent.CodeAct = Activite.CodeAct INNER JOIN
                         Groupe ON Adherent.Groupe = Groupe.CodeG AND Activite.CodeAct = Groupe.Activite INNER JOIN
                         Entraineur ON Groupe.Entraineur = Entraineur.NumE INNER JOIN
                         paiment ON Abonner.codeAb = paiment.CodeAb AND Adherent.NumA = paiment.NumA INNER JOIN
                         Planifier ON Activite.CodeAct = Planifier.CodeAct AND Groupe.CodeG = Planifier.Groupe INNER JOIN
                         Salle ON Groupe.Salle = Salle.NumS AND Planifier.NumS = Salle.NumS INNER JOIN
                         Type_abonnement ON Abonner.CodeTAb = Type_abonnement.CodeTAb
create table Salle(
	NumS int primary key,
	NomS varchar(30),
)

--table Entraineur--
create table Entraineur(
	NumE int primary key,
	NomE varchar(30),
	PrenomE varchar(30),
	LibelleE varchar(50),
	DateN date,
	Sexe varchar(10),
)

----table ACTIVITE ( Sport )--
create table Activite(
	CodeAct int primary key ,
	LibelleAct varchar(20),
)

--table Groupe--
create table Groupe
(
	CodeG int primary key,
	Activite int references Activite(CodeAct),
	DescriptionG text,
	Entraineur int references Entraineur(NumE),
	Salle int references Salle(NumS)
)


--table ADHERENT--
create table Adherent(
	NumA int primary key,
	NomA varchar(30),
	PrenomA varchar(30),
	DateN date,
	DateI date,
	Sexe varchar(10),
	Adresse text,
	VilleA varchar(30),
	Tel varchar(10),
	Groupe int references Groupe(CodeG),
	CodeAct int references Activite(CodeAct),
)
--table Créneau--
create table Créneau(
	CodeC int primary key,
	HeureD date,
	HeureF date,
)
--table jours--
create table jours(
	NumJ int primary key,
	NomJ varchar(20),
)
--table Seance--
create table seance(
	NumSc int primary key,
	Créneau int references Créneau(CodeC),
	Jours int references jours(NumJ),
	Groupe int references Groupe(CodeG),
	Activite int references Activite(CodeAct),
	Entraineur int references Entraineur(NumE)
)


--table Type_abonnement--

create table Type_abonnement(
CodeTAb int primary key,
DescTAb text,
TarifTAb money ,
DureeTAb int                            
)

--table Abonner--
create table Abonner(
	codeAb int primary key,
	CodeTAb int references Type_abonnement(CodeTAb),
	DureeAb int,
	NumA int references Adherent(NumA),                      
)

create table paiment 
(		
	CodeAb int references Abonner(codeAb), 
	NumA int references Adherent(NumA), 
		Montant money, --montant = TarifTAb * duree
	ModeP varchar(20),
	primary key(CodeAb,NumA)
);


--create table Planifier(
--	DateP date,
--	HeurD time,
--	HeurF time,
--	NumS int references Salle(NumS),
--	CodeAct int references Activite(CodeAct),
--	Groupe int references Groupe(CodeG),
--	primary key (NumS,CodeAct,Groupe)
--)

----table LoginAdh--
--create table LoginAdh(
--	NumA int references adherent(NumA),
--	Username varchar(30) unique,
--	Password varchar(20),
--	UserType varchar(10) DEFAULT('adhérent'),
--	primary key(NumA)
--)

----table LoginEntr--
--create table LoginEntr(
--	NumEntr int references ENTRAINEUR(NumE),
--	Username varchar(30) unique,
--	Password varchar(20),
--	UserType varchar(10) DEFAULT('Entraineur'),
--	primary key(NumEntr)
--)

----table ABONNER--
--create table Abonner( 
--	DateD date,
--	DateF date,
--	CodeTAb int references Type_abonnement(CodeTAb),
--	NumA int references Adherent(NumA),
--	primary key (CodeTAb,NumA)
--)

            --INSERTION DE LA TABLE *SALLE*

insert into Salle values(1,'salle Fitness')
insert into Salle values(2,'salle Box')

             --INSERTION DE LA TABLE *ACTIVITE*
			
insert into Activite values(1,'Box')
insert into Activite values(2,'Fitness')

			 --INSERTION DE LA TABLE *Entraineur*--

insert into  Entraineur values(1,'hemadi','Omar','Box Men','2019/03/14','Masculin')
insert into  Entraineur values(2,'Omari','Sanaa','fitness Women','2019/03/14','Féminin')

			--INSERTION DE LA TABLE *Groupe*
insert into  Groupe values(1,1,'Groupe Box Men',1,2)
insert into  Groupe values(2,2,'Groupe Fitness Women',2,1)


			 --INSERTION DE LA TABLE *ADHERENT*--

insert into ADHERENT values(1,'Ourrami','Ali','1997/09/16','2019/03/14','Masculin','HM','CASABLANCA','0619201297',1,1)
insert into ADHERENT values(2,'Alami','Sara','1993/09/16','2019/03/15','Felinin','MA','CASABLANCA','0619201297',2,2)
insert into ADHERENT values(6,'KARAMI','FARID','1992/09/16','2019/03/15','Felinin','MA','CASABLANCA','0619201297',1,1)
insert into ADHERENT values(8,'FARIS','ABDO','1992/09/16','2019/03/15','Felinin','MA','CASABLANCA','0619201297',1,1)

									--INSERTION DE LA TABLE *Type_abonnement*--
insert into Type_abonnement values(1,'Lifestyle Package use 5 once visit cards',1750,2),
									(2,'Fresh package use 3 once visiting cards ',1050,1)


						--INSERTION DE LA TABLE *abonner*--
insert into abonner values(1,1,2,1),
							(2,2,1,2)

						--INSERTION DE LA TABLE *paiment*--
insert into paiment values(1,1,3500,'Espace')
insert into paiment values(2,2,1050,'Espace')

			--INSERTION DE LA TABLE *LoginAdmin*--
insert into LoginAdmin values('admin','admin')


select * from salle
select * from ADHERENT
select * from Entraineur
select * from Activite
select * from Planifier
select * from groupe
select * from Type_abonnement
select * from abonner
select * from paiment
select * from LoginAdmin
