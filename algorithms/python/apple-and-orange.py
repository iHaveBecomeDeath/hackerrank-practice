#!/bin/python3

import sys

def apple_and_orange(s, t, a, b, apples, oranges):
    # s = start of house
    # t = end of house
    # a = pos of apple tree
    # b = pos of orange tree
    # lists = relative distances of fruit from tree
    # inclusive list
    apple_hits = list(filter(lambda x: t >= x >= s, map(lambda x: x + a, apples)))
    orange_hits = list(filter(lambda x: t >= x >= s, map(lambda x: x + b, oranges)))
    return [len(apple_hits), len(orange_hits)]


if __name__ == "__main__":
    s, t = input().strip().split(' ')
    s, t = [int(s), int(t)]
    a, b = input().strip().split(' ')
    a, b = [int(a), int(b)]
    m, n = input().strip().split(' ')
    m, n = [int(m), int(n)]
    apple = list(map(int, input().strip().split(' ')))
    orange = list(map(int, input().strip().split(' ')))
    result = apple_and_orange(s, t, a, b, apple, orange)
    print("\n".join(map(str, result)))

# print(apple_and_orange(7, 11, 5, 15, [-2, 2, 1], [5, -6]))
# 7 11
# 5 15
# 3 2
# -2 2 1
# 5 -6
