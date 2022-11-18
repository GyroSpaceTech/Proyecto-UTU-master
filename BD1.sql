create table usuarios(
Correo varchar(50) not null,
Contra varchar(40)not null,
TipoUsuario enum('normal','pro','Admin'),
primary key (Correo));
insert into usuarios values
(
'Admin@SpaceTech.com', 'prueba', 'Admin'
);
insert into usuarios values
(
'NormalUser@gmail.com', 'prueba', 'normal'
);
insert into usuarios values
(
'ProUser@gmail.com', 'prueba', 'pro'
);

create table deportes(
IdDep int (40) AUTO_INCREMENT NOT NULL,
NomDep varchar(50),
Modalidad enum('equipo','individual'),
TipPuntaje enum('puntos','sets','tiempos'),
primary key (IdDep)
);
insert into deportes (NomDep,Modalidad,TipPuntaje)values(
 'Tenis', 'equipo', 'sets'
);
insert into deportes (NomDep,Modalidad,TipPuntaje)values(
'Football', 'equipo', 'puntos'
);

insert into deportes (NomDep,Modalidad,TipPuntaje)values(
 'Natacion', 'individual', 'tiempos'
);

create table equipo(
IdEquipo int (40) AUTO_INCREMENT NOT NULL,
NomEquipo varchar(50),
ClubORSeleccion enum('club','seleccion'),
IdDeporteJuega int (40) not null,
primary key (IdEquipo),
foreign key (IdDeporteJuega) references deportes(IdDep)
); 
insert into equipo(NomEquipo,ClubORSeleccion,IdDeporteJuega) values(
'Argentina Tenis Club', 'club', '1'
);
insert into equipo(NomEquipo,ClubORSeleccion,IdDeporteJuega) values(
 'Perú Tenis Club', 'club', '1'
);
insert into equipo(NomEquipo,ClubORSeleccion,IdDeporteJuega) values(
 'Messi Fan Club', 'club', '2'
);
insert into equipo(NomEquipo,ClubORSeleccion,IdDeporteJuega) values(
 'Nacional', 'club', '2'
);
insert into equipo(NomEquipo,ClubORSeleccion,IdDeporteJuega) values(
 'Mexico', 'Seleccion', '3'
);insert into equipo(NomEquipo,ClubORSeleccion,IdDeporteJuega) values(
 'Chile', 'Seleccion', '3'
);
create table anuncios(
IdAnun int (40) AUTO_INCREMENT NOT NULL,
NomEmp varchar(50),
Eje enum('horizontal','vertical'),
Contenido enum('video','gif','jpg'),
primary key (IdAnun)
);

create table eventos(
IdDeporte int (40) not null,
IdEvento int (40) AUTO_INCREMENT NOT NULL,
NomEvent varchar(100) not null,
Edicion varchar(50) not null,
Pais varchar(20),
Ubicacion varchar(100),
primary key (IdEvento),
foreign key (IdDeporte) references deportes(IdDep)
);

insert into eventos(IdDeporte,NomEvent,Edicion,Pais,Ubicacion) values(
 '1', 'Tenis Club Tour', '4ta', 'Argentina', 'Bombonera'
);
insert into eventos(IdDeporte,NomEvent,Edicion,Pais,Ubicacion) values(
'2', 'Uruguay fut league ', '1era', 'Uruguay', 'Antel Arena'
);
insert into eventos(IdDeporte,NomEvent,Edicion,Pais,Ubicacion) values(
 '3', 'Natacion olimpics', '2da', 'Russia', '???'
);
create table partidos(
IdResultados int (40) AUTO_INCREMENT NOT NULL,
/*todas la tablas funcionan mal, no todo crea tabla por amor de dios*/
IdEquipo1 int (40) not null,
IdEquipo2 int (40) not null,
InstanciaDeEvento varchar(50) not null,
PuntosE1 int,
PuntosE2 int,
SetE1 int,
SetE2 int,
TiempoOro time,
TiempoPlata time,
TiempoBronce time,
IdEvento int(40),
primary key (IdResultados),
Foreign key partidos(IdEquipo1) references equipo(IdEquipo),
Foreign key (IdEquipo2) references equipo(IdEquipo)
);
Insert into partidos (IdEquipo1,IdEquipo2,InstanciaDeEvento,SetE1,SetE2,IdEvento) values(
 '1', '2', 'final', '3', '2', '1'
);
Insert into partidos (IdEquipo1,IdEquipo2,InstanciaDeEvento,PuntosE1,PuntosE2,IdEvento) values(
'3', '4', '4tos de final', '5', '0', '2'
);
Insert into partidos (IdEquipo1,IdEquipo2,InstanciaDeEvento,TiempoOro,TiempoPlata,TiempoBronce,IdEvento) values(
 '5', '6', 'Semi-Final', '00:00:40', '00:00:45', '00:00:56', '3'

);
create table deportistas(
IdDeportista int (40) AUTO_INCREMENT NOT NULL,
NomDeportista varchar(50),
ApellDeportista varchar(50),
Dorsal varchar(50),
IdEquipo int (80) ,
primary key (IdDeportista),
foreign key (IdEquipo) references equipo(IdEquipo)
);
insert into deportistas(NomDeportista, ApellDeportista,Dorsal,IdEquipo) values(
'Rafael','Sosa','1','1'
);
insert into deportistas(NomDeportista, ApellDeportista,Dorsal,IdEquipo) values(
'Miguel','Soca','1','2'
);
insert into deportistas(NomDeportista, ApellDeportista,Dorsal,IdEquipo) values(
'Nicolas','Castro','9','3'
);
insert into deportistas(NomDeportista, ApellDeportista,Dorsal,IdEquipo) values(
'Miguel','Farias','Mexico','5'
);

insert into deportistas(NomDeportista, ApellDeportista,Dorsal,IdEquipo) values(
'José','Antonio','Chile','6'
);
insert into deportistas(NomDeportista, ApellDeportista,Dorsal,IdEquipo) values(
'Franco','Licro','10','4'
);

create table arbitraje(
IdArb int (40) AUTO_INCREMENT NOT NULL,
NomArb varchar(50),
ApellArb varchar(50),
RolArb varchar(50),
primary key (IdArb)
);
create table UsuariosAnuncios(
Correo_Anun varchar(50),
IdAnun_Usu int (40),
constraint FK_CoAnun foreign key (Correo_Anun)
references usuarios(Correo),
constraint FK_IdAnunUsu foreign key (IdAnun_Usu)
references anuncios(IdAnun)
);

create table UsuariosEventos (
Correo_Event varchar(50),
IdEvent_Usu int(40),
constraint FK_CoEvent foreign key (Correo_Event)
references usuarios(Correo),
constraint FK_IdEventUsu foreign key (IdEvent_Usu)
references eventos(idEvento)
);

create table EventosArbitraje (
IdEvent_Arb int(40),
IdArb_Event int(40),
constraint FK_IdEventArb foreign key (IdEvent_Arb)
references eventos(IdEvento),
constraint FK_IdArbEvent foreign key (IdArb_Event)
references arbitraje(IdArb)
);

create table EventosDeportes (
IdEvent_Dep int(40),
IdDep_Event int(40),
constraint FK_IdEventDep foreign key (IdEvent_Dep)
references eventos(IdEvento),
constraint FK_IdArbEven foreign key (IdDep_Event)
references deportes(IdDep)
);

create table DeportesDeportistas (
IdDeportista_Dep int(40),
IdDep_Deportista int(40),
constraint FK_IdDeportistaDep foreign key (IdDeportista_Dep)
references deportistas(IdDeportista),
constraint FK_IdDepDeportista foreign key (IdDep_Deportista)
references deportes(IdDep)
);

create table DeportesEquipos (
IdDep_Equipo int(40),
IdEquipo_Dep int(40),
constraint FK_IdDepEquipo foreign key (IdDep_Equipo)
references deportes(IdDep),
constraint FK_IdEquipoDep foreign key (IdEquipo_Dep)
references equipo(IdEquipo)
);

create table DeportistasEquipo (
IdDeportista_Equipo int(40),
IdEquipo_Deportista int(40),
constraint FK_IdDeportistaEquipo foreign key 

(IdDeportista_Equipo)
references deportistas(IdDeportista),
constraint FK_IdEquipoDeportista foreign key 

(IdEquipo_Deportista)
references equipo(IdEquipo)
);

