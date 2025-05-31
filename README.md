SnakeGame – gra konsolowa w języku C#

Projekt polega na stworzeniu klasycznej gry Snake w języku C# jako aplikacji konsolowej.  
Gra została wykonana w ramach zadania zaliczeniowego z programowania oraz pracy z systemem kontroli wersji Git i platformą GitHub.

Opis gry

Gracz steruje wężem poruszającym się po planszy. Celem gry jest zbieranie pojawiających się gwiazdek (`*`) – każda z nich zwiększa długość węża oraz liczbę punktów. Gra kończy się w momencie zderzenia ze ścianą lub z własnym ciałem.

Gra zawiera:
- System punktacji
- Dźwięk po zjedzeniu jedzenia
- Ramkę ograniczającą pole gry
- Prosty interfejs konsolowy

Jak uruchomić projekt

1. Otwórz plik `SnakeGame.sln` w programie **Visual Studio 2022**
2. Upewnij się, że projekt buduje się poprawnie
3. Wciśnij **Ctrl + F5**, aby uruchomić grę w trybie bez debugowania
4. Sterowanie: **strzałki** na klawiaturze
5. Aby zakończyć grę, zderz się ze ścianą lub z własnym ogonem

 Struktura projektu

| Plik              | Opis                                     |
|-------------------|------------------------------------------|
| `Program.cs`      | Punkt startowy aplikacji                 |
| `Game.cs`         | Główna pętla gry                         |
| `Snake.cs`        | Logika poruszania się, kolizji, wzrostu  |
| `Food.cs`         | Generowanie i wyświetlanie jedzenia      |
| `ScoreManager.cs` | Liczenie i wyświetlanie punktów          |
| `README.md`       | Instrukcja uruchamiania i opis projektu  |
| `tasks.md`        | Podział zadań zgodnie z instrukcją zadania |

 Git & GitHub

W projekcie wykorzystano:
- repozytorium na GitHubie (`SnakeGame`)
- osobne gałęzie do poszczególnych zadań (`ruch-weza`, `jedzenie`, `punktacja`, `start`, itp.)
- commitowanie zmian z użyciem `git add`, `git commit`, `git push`
- wysyłanie zmian przez **pull requesty** do gałęzi `main`

Status projektu

Projekt został ukończony i przetestowany – działa zgodnie z założeniami:
- poprawnie działa zjadanie gwiazdek
- wynik jest naliczany
- kolizje kończą grę
- gra działa płynnie w konsoli
