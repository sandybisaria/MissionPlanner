print 'Start Script'
for chan in range(1,9):
    Script.SendRC(chan,1500,False)
Script.SendRC(3,Script.GetParam('RC3_MIN'),True)

print 'here'
'''
=======
>>>>>>> 076d7d601425ec67da6dbfbc3d2cf5970fd20eb5
Script.Sleep(2000)
Script.SendRC(3,1000,False)
Script.SendRC(4,2000,True)
cs.messages.Clear()
Script.WaitFor('ARMING MOTORS',30000)
Script.SendRC(4,1500,True)
print 'Motors Armed!'
'''

Script.SendRC(3,1100,True)
Script.Sleep(5000)

file = open("videoInstructions.txt", "r")
instruction = file.readline()

while(True):
	print instruction

	if(instruction == 'straight'):
		Script.SendRC(3,1100,True)
		Script.Sleep(5000)
	elif(instruction == 'right'):
		new = cs.yaw + 50
		Script.SendRC(3,1050,True)
		Script.SendRC(4,1750, True)
		print 'bob'
		#while(cs.yaw < new):
		#	Script.Sleep(10)
	elif(instruction == 'left'):
		Script.SendRC(3,1100,True)
		Script.Sleep(2000)

#Script.ChangeMode("LAND")


for chan in range(1,9):
	Script.SendRC(chan,0,True)

#while cs.alt > 0.5:
# Script.SendRC(3,1000,False)
# Script.SendRC(4,1000,True)
# Script.WaitFor('DISARMING MOTORS',30000)
# Script.SendRC(4,1500,True)
# print 'Motors Disarmed!'

Script.ChangeMode("Stabilize")
