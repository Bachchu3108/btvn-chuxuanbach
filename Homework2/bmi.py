height = float(input("What's your height in cm? "))/100
weight = float(input("What's your weight in kg? "))
bmi = float(weight / (height**2))

print("Your BMI is:", bmi )
if bmi < 16:
    print("You're severely underweight")
elif bmi <= 18.5:
    print("You're underweight")
elif bmi <= 25:
    print("You're normal")
elif bmi <= 30:
    print("You're overweight")
elif bmi > 30:
    print("You're obese")
