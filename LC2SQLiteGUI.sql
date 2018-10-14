drop table IF EXISTS url;
create table IF NOT EXISTS url (
 name varchar(255)
/*   name1 varchar(255),
  name2 varchar(255),
  name3 varchar(255),
  name4 varchar(255),
  name5 varchar(255),
  name6 varchar(255),
  name7 varchar(255),
  name8 varchar(255),
  name9 varchar(255),
  name10 varchar(255),
  name11 varchar(255),
  name12 varchar(255),
  name13 varchar(255),
  name14 varchar(255),
  name15 varchar(255),
  name16 varchar(255),
  name17 varchar(255),
  name18 varchar(255),
  name19 varchar(255),
  name21 varchar(255),
  name22 varchar(255),
  name23 varchar(255),
  name24 varchar(255),
  name25 varchar(255),
  name26 varchar(255),
  name27 varchar(255),
  name28 varchar(255),
  name29 DECIMAL(10,5),
  name30 DECIMAL(10,5),
  name31 varchar(255),
  name32 varchar(255),
  name33 varchar(255),
  name34 varchar(255),
  name35 varchar(255),
  name36 varchar(255),
  name37 varchar(255),
  name38 varchar(255),
  name39 varchar(255),
  name40 varchar(255),
  name41 varchar(255),
  name42 varchar(255),
  name43 varchar(255),
  name44 varchar(255),
  name45 varchar(255)   */
);
.separator "\t"
.import import\\import.csv url
--.import ..\\import\\materialnohead.csv url
--INSERT INTO person VALUES (4, 'Alice', '351246233');
DELETE FROM url where url.name = '';
.exit