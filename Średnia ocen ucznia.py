liczba_ocen = int(input("Ile ocen chcesz wprowadzić? "))

suma = 0

for i in range(liczba_ocen):
    ocena = float(input(f"Podaj ocenę {i + 1}: "))
    while ocena < 1 or ocena > 6:
        print("Ocena musi być w zakresie 1–6.")
        ocena = float(input(f"Podaj ocenę {i + 1} ponownie: "))
    suma += ocena

srednia = suma / liczba_ocen

print(f"Średnia: {srednia:.2f}")

if srednia >= 3.0:
    print("Uczeń zdał.")
else:
    print("Uczeń nie zdał.")
