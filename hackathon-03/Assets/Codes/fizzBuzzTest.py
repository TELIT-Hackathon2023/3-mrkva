import subprocess

def check_fizzbuzz_solution(file_path):
    try:
        result = subprocess.run(['python', file_path], capture_output=True, text=True)
        output = result.stdout.strip().split('\n')

        # Generating the correct FizzBuzz sequence
        correct_sequence = []
        for i in range(1, 101):
            if i % 3 == 0 and i % 5 == 0:
                correct_sequence.append("FizzBuzz")
            elif i % 3 == 0:
                correct_sequence.append("Fizz")
            elif i % 5 == 0:
                correct_sequence.append("Buzz")
            else:
                correct_sequence.append(str(i))
        if output == correct_sequence:
            print("Nice job!")
        else:
            print("That's not quite right. Try again.")

    except Exception as e:
        print(f"Error in running the script: {e}")

if __name__ == "__main__":
    check_fizzbuzz_solution('taskFizzBuzz.py')