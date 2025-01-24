ROZLICZENIEAPP

Aplikacja RozliczenieApp to aplikacja desktopowa wspomagająca zarządzanie pracą kierowców. Głównym celem biznesowym jest umożliwienie efektywnego rejestrowania i rozliczania kursów wykonywanych przez kierowców, w tym : 
- Przechowywania danych kierowców, ich pojazdów oraz wykonanych kursów.
- Automatycznego obliczania zarobków kierowców na podstawie zarejestrowanych danych.
- Wspierania logistyki i księgowości w małych firmach transportowych.

Lista funkcjonalności:
1. Zarządzanie użytkownikami
- Rejestracja nowych użytkowników.
-Logowanie istniejących użytkowników z walidacją danych.
2. Zarządzanie kierowcami
- Dodawanie nowych kierowców do systemu.
- Przechowywanie informacji o kierowcy, takich jak imię, nazwisko, numer rejestracyjny pojazdu i typ pojazdu.
3. Rejestrowanie kursów
- Dodawanie informacji o kursach, w tym daty, liczby kursów i zarobionej kwoty.
- Automatyczne obliczanie wynagrodzenia na podstawie stawki zależnej od dnia tygodnia.
- Wyświetlanie listy zarejestrowanych kursów dla danego kierowcy.
4. Obsługa bazy danych SQLite
-Przechowywanie wszystkich danych (użytkownicy, kierowcy, kursy) w lekkiej bazie danych SQLite.
- Automatyczne tworzenie tabel przy pierwszym uruchomieniu aplikacji.

Instalacja i uruchomienie

Tryb DEBUG

Krok 1:

Skopiuj link z https://github.com/zozol2233/RozliczeniePracyKierowcy/blob/main/Debug

Krok 2:

W Visual Studio otwórz projekt i uruchom nuget restore

Krok 3:

W Visual Studio kliknij przycisk Start lub naciśnij F5.

Tryb RELEASE

Krok 1:
https://github.com/zozol2233/RozliczeniePracyKierowcy
Przejdź do zakładki "Releases"

Krok 2: 
W sekcji release pobierz plik RozliczenieApp.exe

Krok 3:
Uruchom aplikację

Użyte technologie:

- Język programowania: C# (.NET Framework)
- Baza danych: SQLite
- Zarządzanie ORM: Entity Framework
- IDE: Visual Studio
Biblioteki:
- System.Data.SQLite
- EntityFramework
