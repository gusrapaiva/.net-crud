create database agenda;
use agenda;

create table tbContato (codContato int auto_increment primary key,
						nome varchar(40) not null,
						telefone char(13),
						celular char(14),
                        email varchar(35) unique not null
);

create table tbLogin(	login varchar(30) not null primary key,
						senha varchar(30) not null
);

insert into tbLogin values ('adm', '123');

select * from tbContato;
select * from tbLogin;