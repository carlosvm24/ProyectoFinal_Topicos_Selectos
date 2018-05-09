CREATE OR REPLACE PACKAGE pkg_bd AS

PROCEDURE check_login(
p_users OUT SYS_REFCURSOR,
p_user_name IN VARCHAR2,
p_user_passwd IN VARCHAR2
);

PROCEDURE delete_user(
p_users OUT SYS_REFCURSOR,
p_user_name IN VARCHAR2
);

PROCEDURE edit_user(
p_users OUT SYS_REFCURSOR,
p_user_rank IN VARCHAR2,
p_user_name IN VARCHAR2
);
PROCEDURE create_user(
p_users OUT SYS_REFCURSOR,
p_user_name IN VARCHAR2,
p_user_passwd IN VARCHAR2
);



END pkg_bd;
/

CREATE OR REPLACE PACKAGE BODY pkg_bd AS

PROCEDURE check_login(
p_users OUT SYS_REFCURSOR,
p_user_name IN VARCHAR2,
p_user_passwd IN VARCHAR2
) AS
BEGIN 
    OPEN p_users FOR
    SELECT *
        FROM officer
        WHERE officer.name = p_user_name AND officer.password = p_user_passwd;
    
END check_login;

PROCEDURE delete_user(
p_users OUT SYS_REFCURSOR,
p_user_name IN VARCHAR2
) AS
BEGIN
    DELETE from officer
        WHERE officer.name = p_user_name;
END delete_user;

PROCEDURE edit_user(
p_users OUT SYS_REFCURSOR,
p_user_rank IN VARCHAR2,
p_user_name IN VARCHAR2
) AS
BEGIN
    UPDATE officer
        SET officer.rank = p_user_rank
        WHERE officer.name = p_user_name;
END edit_user;

PROCEDURE create_user(
p_users OUT SYS_REFCURSOR,
p_user_name IN VARCHAR2,
p_user_passwd IN VARCHAR2
) AS
BEGIN
    INSERT INTO officer(name, password)
    VALUES(p_user_names, p_user_passwd);
    
END create_user;
    


END pkg_bd;