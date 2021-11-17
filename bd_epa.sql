create database bd_epa;
use bd_epa;

create table usuario(
id int unsigned not null auto_increment,
email varchar(50) not null,
senha varchar(30) not null,
primary key(id)
)engine = innodb;

create table produto(
id int unsigned not null auto_increment,
nome varchar(45) not null,
preco double(9,2) not null,
marca varchar(30) not null,
descricao text not null,
primary key(id)
)engine = innodb;

insert into usuario value(null,"usuario1@gmail.com","123");

insert into produto
values(null, "Biscoito recheado",1.84,"Aymoré","Biscoito recheado sabor chocolate, 120g."),
(null,"Mentos Fruit",1.20,"Mentos","Mentos stick fruit, sabores sortidos de fruta, 14 unidades.");