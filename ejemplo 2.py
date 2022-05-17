#El error aquí es que utilizamos una redundancia en decir "== True" porque por defecto las condiciones evaluan esto así

a = True

if a == True:
    print(a)

if a == False:
    print(a)


def bool():
    return True

if bool() == True:
    print(a)

#______________________________________________________________________________________________

b = True

if b:
    print(a)

if not b:
    print(a)


def bool2():
    return True


if bool2():
    print(b)