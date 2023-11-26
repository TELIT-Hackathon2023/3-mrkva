# Task: Modify this script to print the first 10 prime numbers.

def is_prime(n):
    """Check if a number is prime."""
    if n <= 1:
        return False
    for i in range(2, int(n**0.5) + 1):
        if n % i == 0:
            return False
    return True

def print_first_n_primes(n):
    """Print the first n prime numbers."""
    count = 0
    num = 2

    while count < n:
        if is_prime(num):
            print(num)
            count += 1
        num += 1

print_first_n_primes(10)