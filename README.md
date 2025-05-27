liczba1 = float(input("Podaj pierwszą liczbę: "))
liczba2 = float(input("Podaj drugą liczbę: "))
operacja = input ("Wybierz operację (+, -, *, /): ")

if operacja == "+":
    wynik = liczba1 + liczba2
elif operacja == "-":
    wynik = liczba1 - liczba2
elif operacja == "*":
    wynik = liczba1 * liczba2
elif operacja == "/":
    if liczba2 != 0:
        wynik = liczba1 / liczba2
    else:
        wynik = "Błąd:nie można dzielić przez zero!"
else:
    wynik = "Błąd:nieprawidłowa operacja!"

print("Wynik:", wynik)
