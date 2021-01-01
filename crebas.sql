/*==============================================================*/
/* DBMS name:      MySQL 5.0                                    */
/* Created on:     2020/6/15 16:38:19                           */
/*==============================================================*/


drop table if exists admin_user;

drop table if exists c_client;

drop table if exists class;

drop table if exists d_departments;

drop table if exists d_departments_and_e_device;

drop table if exists e_device;

drop table if exists e_device_and_s_staff;

drop table if exists repair;

drop table if exists s_staff;

/*==============================================================*/
/* Table: admin_user                                            */
/*==============================================================*/
create table admin_user
(
   aid                  int not null,
   username             varbinary(15) not null,
   password             varbinary(20) not null,
   primary key (aid, username, password)
);

/*==============================================================*/
/* Table: c_client                                              */
/*==============================================================*/
create table c_client
(
   cid                  int(15) not null,
   ccard                varchar(20),
   cclass               int(10) not null,
   cname                varchar(20),
   ctele                varchar(20),
   ccompany             varchar(30),
   primary key (cid)
)
ENGINE=MyISAM AUTO_INCREMENT=5 DEFAULT CHARSET=utf8 COLLATE=utf8_bin;

/*==============================================================*/
/* Table: class                                                 */
/*==============================================================*/
create table class
(
   cid                  int(10) not null auto_increment,
   class                varchar(15),
   primary key (cid)
)
ENGINE=MyISAM AUTO_INCREMENT=5 DEFAULT CHARSET=utf8 COLLATE=utf8_bin;

/*==============================================================*/
/* Table: d_departments                                         */
/*==============================================================*/
create table d_departments
(
   did                  int(10) not null auto_increment,
   sid                  int(20),
   scard                varchar(15),
   dname                varchar(20),
   ddescription         varchar(50),
   ddevice              int(20) default NULL,
   ddevicenums          int(5) default NULL,
   primary key (did)
)
ENGINE=MyISAM AUTO_INCREMENT=12 DEFAULT CHARSET=utf8 COLLATE=utf8_bin;

/*==============================================================*/
/* Table: d_departments_and_e_device                            */
/*==============================================================*/
create table d_departments_and_e_device
(
   edid                 int(20) not null auto_increment,
   did                  int(10) not null,
   eid                  int(10) not null,
   primary key (edid),
   key eid (eid),
   key did (did)
)
ENGINE=MyISAM AUTO_INCREMENT=10 DEFAULT CHARSET=utf8 COLLATE=utf8_bin;

/*==============================================================*/
/* Table: e_device                                              */
/*==============================================================*/
create table e_device
(
   eid                  int(10) not null auto_increment,
   ename                varchar(20),
   enums                int(5) default NULL,
   estatus              varchar(10),
   evalue               float(15,0) not null,
   primary key (eid),
   key edepart (eid)
)
ENGINE=MyISAM AUTO_INCREMENT=6 DEFAULT CHARSET=utf8 COLLATE=utf8_bin;

/*==============================================================*/
/* Table: e_device_and_s_staff                                  */
/*==============================================================*/
create table e_device_and_s_staff
(
   edid                 int(20) not null auto_increment,
   scard                varchar(15),
   eid                  int(10) not null,
   sid                  int(20),
   eidnums              int(5) default NULL,
   primary key (edid),
   key eid (eid),
   key scard (scard)
)
ENGINE=MyISAM AUTO_INCREMENT=12 DEFAULT CHARSET=utf8 COLLATE=utf8_bin;

/*==============================================================*/
/* Table: repair                                                */
/*==============================================================*/
create table repair
(
   rid                  int(10) not null auto_increment,
   did                  int(10),
   sid                  int(20),
   scard                varchar(15),
   sscard               varchar(15),
   sname                varchar(20),
   ename                varchar(20),
   rstatus              int(2) default NULL,
   primary key (rid)
)
ENGINE=MyISAM AUTO_INCREMENT=2 DEFAULT CHARSET=utf8 COLLATE=utf8_bin;

/*==============================================================*/
/* Table: s_staff                                               */
/*==============================================================*/
create table s_staff
(
   sid                  int(20) not null auto_increment,
   scard                varchar(15) not null,
   sname                varchar(15),
   ssex                 varchar(5),
   sage                 int(4) default NULL,
   saddress             varchar(20),
   money                float(6,0) default NULL,
   sdepartment          int(5) not null,
   sdevice              int(5) default NULL,
   sdevicenums          int(5) default NULL,
   primary key (sid, scard),
   key d_department (sdepartment)
)
ENGINE=MyISAM AUTO_INCREMENT=19 DEFAULT CHARSET=utf8 COLLATE=utf8_bin;

alter table c_client add constraint FK_Reference_9 foreign key (cid)
      references class (cid) on delete restrict on update restrict;

alter table d_departments add constraint FK_Reference_6 foreign key (sid, scard)
      references s_staff (sid, scard) on delete restrict on update restrict;

alter table d_departments_and_e_device add constraint FK_Reference_4 foreign key (eid)
      references e_device (eid) on delete restrict on update restrict;

alter table d_departments_and_e_device add constraint FK_Reference_5 foreign key (did)
      references d_departments (did) on delete restrict on update restrict;

alter table e_device_and_s_staff add constraint FK_Reference_10 foreign key (eid)
      references e_device (eid) on delete restrict on update restrict;

alter table e_device_and_s_staff add constraint FK_Reference_11 foreign key (sid, scard)
      references s_staff (sid, scard) on delete restrict on update restrict;

alter table repair add constraint FK_Reference_7 foreign key (did)
      references d_departments (did) on delete restrict on update restrict;

alter table repair add constraint FK_Reference_8 foreign key (sid, scard)
      references s_staff (sid, scard) on delete restrict on update restrict;

