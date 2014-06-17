print 'Start Script'

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

Script.SendRC(7,1850,True)
Script.Sleep(5000)

Script.SendRC(7,1100,True)
Script.Sleep(5000)

print 'ending'

