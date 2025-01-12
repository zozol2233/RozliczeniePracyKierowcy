Tak miało być

Funkcjonalność aplikacji
1. Automatyczne pobieranie bieżącej daty
•	Podczas dodawania nowego kursu aplikacja automatycznie ustawia datę jako bieżącą (pobieraną z systemu komputera).
•	Możliwość edycji wcześniejszych dni: Użytkownik może ręcznie zmienić datę w przypadku uzupełniania danych historycznych.
________________________________________
2. Rejestrowanie kursów dziennych
•	Dane wprowadzane przez użytkownika:
o	Liczba kursów w danym dniu.
o	Opis (np. nazwy lokalizacji kursów).
•	Aplikacja automatycznie oblicza zarobki na podstawie reguł:
o	Dni robocze:
	Pierwsze dwa kursy: 230 zł.
	Trzeci kurs: +80 zł.
	Każdy kolejny: +120 zł.
o	Soboty:
	Każdy kurs: 100 zł + 80 zł dodatkowo do dniówki.
o	Niedziele:
	Każdy kurs: 100 zł + 100 zł dodatkowo do dniówki.
________________________________________
3. Wyświetlanie listy kursów
•	Tabela dzienna:
o	Wyświetla wszystkie kursy wprowadzone dla bieżącego dnia.
•	Możliwość edycji:
o	Użytkownik może kliknąć wybrany dzień w kalendarzu lub tabeli, aby:
	Zaktualizować liczbę kursów, opis lub kwotę.
	Usunąć kurs.
•	Tabela zawiera kolumny:
o	Data.
o	Opis.
o	Liczba kursów.
o	Zarobiona kwota.
________________________________________
4. Podsumowanie miesiąca
•	Wyświetlanie całkowitych zarobków za wybrany miesiąc.
•	Szczegóły:
o	Suma kursów i kwot dla poszczególnych dni.
o	Łączna kwota zarobiona w miesiącu.
•	Filtrowanie danych: Możliwość przeglądania wyników z dowolnego miesiąca i roku.
________________________________________
5. Eksport danych do pliku PDF
•	Generowanie raportu zawierającego:
o	Daty, liczby kursów i opisy.
o	Zarobki za każdy dzień.
o	Całkowite zarobki w miesiącu.
•	Raporty zapisywane lokalnie na komputerze w wybranej lokalizacji.
________________________________________
6. Przechowywanie danych historycznych
•	Wszystkie dane kursów przechowywane w lokalnej bazie danych (SQLite).
•	Użytkownik może:
o	Przeglądać dane historyczne.
o	Uzupełniać brakujące wpisy w wybranych dniach.
o	Aktualizować istniejące wpisy.
________________________________________
Technologie i narzędzia
1.	Windows Forms (WinForms):
o	Framework do tworzenia aplikacji desktopowej z graficznym interfejsem użytkownika.
o	Komponenty:
	DateTimePicker: Domyślnie ustawiony na dzisiejszą datę, z możliwością zmiany.
	DataGridView: Wyświetlanie listy kursów i zarobków.
	TextBox: Wprowadzanie opisu kursów.
	Button: Dodawanie kursów, generowanie raportów, zapisywanie zmian.
2.	SQLite:
o	Lekka baza danych lokalna.
o	Przechowuje dane kursów i zarobków w jednym pliku (kursy.db).
3.	QuestPDF:
o	Biblioteka do generowania raportów PDF.
4.	C# i .NET Framework:
o	Do logiki aplikacji, zarządzania danymi i operacjami na plikach.

a jest tak :

Funkcjonalność aplikacji
1. Automatyczne pobieranie bieżącej daty
•	Podczas dodawania nowego kursu aplikacja automatycznie ustawia datę jako bieżącą (pobieraną z systemu komputera).
•	Możliwość edycji wcześniejszych dni: Użytkownik może ręcznie zmienić datę w przypadku uzupełniania danych historycznych.
________________________________________
2. Rejestrowanie kursów dziennych
•	Dane wprowadzane przez użytkownika:
o	Liczba kursów w danym dniu.
o	Opis (np. nazwy lokalizacji kursów).
•	Aplikacja automatycznie oblicza zarobki na podstawie reguł:
o	Dni robocze:
	Pierwsze dwa kursy: 230 zł.
	Trzeci kurs: +80 zł.
	Każdy kolejny: +120 zł.
o	Soboty:
	Każdy kurs: 100 zł + 80 zł dodatkowo do dniówki.
o	Niedziele:
	Każdy kurs: 100 zł + 100 zł dodatkowo do dniówki.
________________________________________
3. Wyświetlanie listy kursów
•	Tabela dzienna:
o	Wyświetla wszystkie kursy wprowadzone dla bieżącego dnia.
•	Tabela zawiera kolumny:
o	Data.
o	Opis.
o	Liczba kursów.
o	Zarobiona kwota.
________________________________________

Technologie i narzędzia
1.	Windows Forms (WinForms):
o	Framework do tworzenia aplikacji desktopowej z graficznym interfejsem użytkownika.
o	Komponenty:
	DateTimePicker: Domyślnie ustawiony na dzisiejszą datę, z możliwością zmiany.
	DataGridView: Wyświetlanie listy kursów i zarobków.
	TextBox: Wprowadzanie opisu kursów.
	Button: Dodawanie kursów, generowanie raportów, zapisywanie 
2.	C# i .NET Framework:
o	Do logiki aplikacji, zarządzania danymi i operacjami na plikach.



