import numpy as np

class MyRandom(object):
    def __init__(self, seed: int, operation: str ="+", j: int =1, k: int =4, m: int =16):
        """An implementation of the Lagged Fibonacci Generator. 
        Allows for additive, subtractive and multiplicative variations. """
        assert 0 < j < k
        seed = str(seed)
        assert len(seed) >= k
        
        if operation == "+":
            self.op = lambda x, y : x + y
            self.period = (2**k -1 ) * 2**(m-1)
        elif operation == "*":
            self.op = lambda x, y : x * y
            self.period = (2**k - 1) * 2**(m-3)
        elif operation == "-":
            self.op = lambda x, y : x - y
            self.period = (2**k - 1) * 2**(m-1)
        else:
            raise Exception
        
        self.seed = np.fromiter(map(int, seed), dtype=np.int)
        self.j = j
        self.k = k
        self.m = m
        self.RAND_MAX = m - 1
    def random(self):
        """Generates a random number between 0 and m-1"""
        randint = self.op(self.seed[self.j-1], self.seed[self.k-1]) % self.m
        self.seed = np.append(self.seed[1:], randint)
        return randint
    
    def randfloat(self):
        """Generates a random number between 0 and 1"""
        randint = self.random()
        randfloat = randint / self.RAND_MAX
        return randfloat
        
        