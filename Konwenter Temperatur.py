kierunek = input("Wybierz kierunek konwersji (C - Celsjusz na Fahrenheit, F - Fahrenheit na Celsjusz): ").upper()

if kierunek == "C":
    temp_c = float(input("Podaj temperaturę w stopniach Celsjusza: "))
    temp_f = temp_c * 1.8 + 32
    print(f"{temp_c}°C = {temp_f}°F")
elif kierunek == "F":
    temp_f = float(input("Podaj temperaturę w stopniach Fahrenheita: "))
    temp_c = (temp_f - 32) / 1.8
    print(f"{temp_f}°F = {temp_c}°C")
else:
    print("Błąd: nieprawidłowy wybór kierunku konwersji.")
