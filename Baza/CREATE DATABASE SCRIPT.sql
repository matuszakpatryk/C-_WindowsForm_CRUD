CREATE TABLE klient(
	id_klient INT IDENTITY (1,1) PRIMARY KEY,
	imie VARCHAR(50) NULL,
	nazwisko VARCHAR(50) NULL,
	telefon VARCHAR(50) NULL,
	email VARCHAR(50) NULL
);

CREATE TABLE pracownik(
	id_pracownik INT IDENTITY (1,1) PRIMARY KEY,
	imie VARCHAR(50) NULL,
	nazwisko VARCHAR(50) NULL,
	telefon VARCHAR(50) NULL,
	email VARCHAR(50) NULL,
	PESEL VARCHAR(11) NULL
);

CREATE TABLE produkt(
	id_produkt INT IDENTITY (1,1) PRIMARY KEY,
	nazwa VARCHAR(50) NULL,
	cena_netto VARCHAR(50) NULL,
	vat VARCHAR(50) NULL,
	cena_brutto VARCHAR(50) NULL,
	ilosc VARCHAR(11) NULL
);

CREATE TABLE sprzedaz(
	id_sprzedaz INT IDENTITY (1,1) PRIMARY KEY,
	nrParagonu VARCHAR(50) NULL,
	id_pracownik INT FOREIGN KEY REFERENCES pracownik(id_pracownik),
	id_klient INT FOREIGN KEY REFERENCES klient(id_klient),
	wartosc MONEY DEFAULT(0),
	data DATE NULL
);

CREATE TABLE koszyk(
	id_sprzeda¿ INT FOREIGN KEY REFERENCES sprzedaz(id_sprzedaz),
	id_produkt INT FOREIGN KEY REFERENCES produkt(id_produkt),
	ilosc INT,
	cena_jednostkowa MONEY,
	wartosc MONEY
);