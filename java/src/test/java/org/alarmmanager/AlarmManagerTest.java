package org.alarmmanager;

import org.alarmmanager.external.EmailAlarm;
import org.junit.Assert;
import org.junit.Test;

public class AlarmManagerTest {

    @Test
    public void alarmManagerRaisesEmailAlarm() {
        
        var alarmManager = new AlarmManager();
        alarmManager.raiseAlarm("ufos coming!");

        Assert.assertEquals(1, EmailAlarm.emailAlarmsSent.size());
        Assert.assertTrue("alarm sent via MS Teams", EmailAlarm.emailAlarmsSent.contains("ufos coming!"));
    }
}
