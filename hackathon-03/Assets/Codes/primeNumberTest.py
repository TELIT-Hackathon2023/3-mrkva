import subprocess

def check_solution(file_path):
    try:
        # Running the task script as a subprocess and capturing its output
        result = subprocess.run(['python', file_path], capture_output=True, text=True)

        # Getting the output from the task script
        output = result.stdout.strip().split('\n')

        correct_primes = ['2', '3', '5', '7', '11', '13', '17', '19', '23', '29']
        if all(num.strip() in correct_primes for num in output) and len(output) == 10:
            print("Nice job!")
        else:
            print("That's not quite right. Try again.")

    except Exception as e:
        print(f"Error in running the script: {e}")

if __name__ == "__main__":
    check_solution('taskPrime.py')