
create table t_user_account (
user_id   INTEGER PRIMARY KEY AUTOINCREMENT,
user_role            VARCHAR(30),
user_name            VARCHAR(30),
user_pwd             VARCHAR(50)

);

create table t_emp (
t_emp_id            INTEGER PRIMARY KEY AUTOINCREMENT,
user_id              INTEGER(50),
t_out_id             INTEGER(50),
emp_first_name       VARCHAR(10),
emp_last_name        VARCHAR(10),
t_emp_mobile         VARCHAR(20),
t_manager_id         VARCHAR(50)
);

create table t_data_dic (
t_dic_id             INTEGER PRIMARY KEY AUTOINCREMENT,
t_name_dic           VARCHAR(30),
t_type_dic           VARCHAR(10)

);


create table t_customer (
cust_id              INTEGER PRIMARY KEY AUTOINCREMENT,
user_id              INTEGER(50),
c_first_name         VARCHAR(20),
c_last_name          VARCHAR(20),
c_phone              VARCHAR(30),
c_email              VARCHAR(50),
c_address            VARCHAR(200)
);


create table t_car (
car_id               INTEGER PRIMARY KEY AUTOINCREMENT,
cust_id              INTEGER(50),
t_out_id             INTEGER(50),
car_model            INTEGER(50),
car_regist_num       VARCHAR(50)
);

create table t_job (
t_job_id             INTEGER PRIMARY KEY AUTOINCREMENT,
t_desk_staff_id      INTEGER(50),
t_worker_id          INTEGER(50),
car_id               INTEGER(50),
t_job_type           INTEGER(50),
t_job_status         VARCHAR(10),
t_open_date          VARCHAR(20),
t_close_date         VARCHAR(20),
t_priority_level     VARCHAR(10)

);


create table t_job_log (
t_log_id             INTEGER PRIMARY KEY AUTOINCREMENT,
t_job_id             INTEGER(50),
t_emp_id             INTEGER(50),
t_log_desc           VARCHAR(1000),
t_date               VARCHAR(20)
);


create table t_outlet (
t_out_id              INTEGER PRIMARY KEY AUTOINCREMENT,
t_out_name           VARCHAR(50),
t_out_address        VARCHAR(100),
t_out_city           VARCHAR(20),
t_out_phone          VARCHAR(20)

);