INSERT INTO tRol (rolName, rolDescription, admin) VALUES ('ADMIN', 'Administrador', 1);
INSERT INTO tRol (rolName, rolDescription, admin) VALUES ('USER', 'Usuaio', 0);
INSERT INTO tRol (rolName, rolDescription, admin) VALUES ('INV', 'Invitado', 0);

INSERT INTO tUser (name, password, rolName) VALUES ('u1', 'u1', 'ADMIN');
INSERT INTO tUser (name, password, rolName) VALUES ('u2', 'u2', 'USER');
INSERT INTO tUser (name, password, rolName) VALUES ('u3', 'u3', 'INV');

INSERT INTO tPermision (rolName, screen, access, modify) VALUES ('ADMIN', 'Login', 1, 1);
INSERT INTO tPermision (rolName, screen, access, modify) VALUES ('USER', 'Login', 1, 1);
INSERT INTO tPermision (rolName, screen, access, modify) VALUES ('INV', 'Login', 0, 0);

INSERT INTO tPermision (rolName, screen, access, modify) VALUES ('ADMIN', 'P1', 1, 1);
INSERT INTO tPermision (rolName, screen, access, modify) VALUES ('USER', 'P1', 1, 0);
INSERT INTO tPermision (rolName, screen, access, modify) VALUES ('INV', 'P1', 0, 0);

INSERT INTO tPermision (rolName, screen, access, modify) VALUES ('ADMIN', 'P2', 1, 1);
INSERT INTO tPermision (rolName, screen, access, modify) VALUES ('USER', 'P2', 1, 1);
INSERT INTO tPermision (rolName, screen, access, modify) VALUES ('INV', 'P2', 0, 0);

INSERT INTO tPermision (rolName, screen, access, modify) VALUES ('ADMIN', 'P3', 1, 1);
INSERT INTO tPermision (rolName, screen, access, modify) VALUES ('USER', 'P3', 1, 0);
INSERT INTO tPermision (rolName, screen, access, modify) VALUES ('INV', 'P3', 0, 0);

