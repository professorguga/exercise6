import library

a, b, c, d, e, f = 5, 3, 7, 4, 2, 10
x, y, z, is_admin = True, False, True, False

print(library.or_func(library.and_func(library.greater_than(library.add(a, library.multiply(b, c)), library.subtract(d, e)), x), y))
print(library.and_func(library.and_func(library.less_equal(library.multiply(library.subtract(a, b), library.add(c, d)), e), z), library.not_func(x)))
print(library.or_func(library.equal(library.mod(library.add(library.add(a, b), c), d), 0), library.and_func(library.greater_than(f, e), is_admin)))
print(library.and_func(library.not_func(library.or_func(x, y)), library.greater_than(library.multiply(a, a), library.multiply(b, c))))