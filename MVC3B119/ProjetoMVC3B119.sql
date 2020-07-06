create database ProjetoMVC3D240;
use ProjetoMVC3D240;

create table tbl_cliente3D240 (
	id_cliente int primary key not null,
	nome_cliente varchar(45) not null,
	sobrenome_cliente varchar(45) not null,
	email_cliente varchar(50) not null,
	senha_cliente varchar(16) not null,
	cpf_cliente char(11) not null,
	nome_mae varchar(50) not null,
	tp_usuario int not null
);

insert into tbl_cliente3D240 values (1, 'Wellerson', 'Drumond', 'wellerson@email.com', 'senha123', '32412354321', 'Josicleide', 1);
insert into tbl_cliente3D240 values (2, 'Otaviano', 'Silvério', 'otaviano@email.com', 'foobar', '21334212356', 'Zumira', 2);

select * from tbl_cliente3D240;