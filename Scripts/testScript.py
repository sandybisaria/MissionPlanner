print 'Start Script'
for chan in range(1,9):
    Script.SendRC(chan,1500,False)
Script.SendRC(3,Script.GetParam('RC3_MIN'),True)

Script.Sleep(5000)
Script.SendRC(3,1000,False)
Script.SendRC(4,2000,True)
cs.messages.Clear()
Script.WaitFor('ARMING MOTORS',30000)
Script.SendRC(4,1500,True)
print 'Motors Armed!'

Script.Sleep(1000)

#Script.SendRC(3,1700,True)
"""
while cs.alt < 1:
    Script.Sleep(50)
"""

Script.Sleep(1000)

"""
Script.SendRC(3,1300,True)
while cs.alt > 0.5:
    Script.Sleep(300)
"""


for chan in range(1,9):
    Script.SendRC(chan,0,True)
#while cs.alt > 0.5:
# Script.SendRC(3,1000,False)
# Script.SendRC(4,1000,True)
# Script.WaitFor('DISARMING MOTORS',30000)
# Script.SendRC(4,1500,True)
# print 'Motors Disarmed!'

Script.Sleep(1000)
Script.ChangeMode("Stabilize")