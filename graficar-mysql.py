import sys
from pylab import *
import MySQLdb

db = MySQLdb.connect(sys.argv[1], sys.argv[2], sys.argv[3],
                    sys.argv[4])
cursor = db.cursor()

query = sys.argv[5]
cursor.execute(query)
result = cursor.fetchall()

t = []
s = []

for record in result:
  t.append(record[0])
  s.append(record[1])

plot(t, s, 'ko')
axis([min(t), max(t), min(s), max(s)])
title(query)
grid(True)

F = gcf()
DPI = F.get_dpi()
F.savefig('plot.png',dpi = (80))