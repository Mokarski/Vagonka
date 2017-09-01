Выполняемые функции:
Обновление ПО 
Первичная загрузка ПО
Тестирование связи между узлами
Внутреннее тестирование
Сбор отладочных данных

Для УСТАНОВКИ программы ssh_updater, распакуйте архив ssh_updater.zip в корневую директорию любого диска, например диска С: (c:/ssh_updater)

Для ЗАПУСКА программы ssh_updater зайдите в папку c:/ssh_updater и сделайте двойной щелчок по файлу start.bat

Для ПЕРЕПРОШИВКИ необходимо сделать следующее (для смены прошивки в процессоре)
1 - Подключить панель43 или процессор к ноутбуку с установленной программой ssh_updater через ethernet кабель или коммутатор, допускается так-же использование одного из портов каплера (WAGO) как транзитного коммутатора.

2 - запустить программу ssh_updater и выбрать пункт 4 (нажав цифру 4 на клавиатуре) далее жмем клавишу ввода.
    ВНИМАНИЕ! при первичном подключении устройства  может появиться надпись на английском языке: 

WARNING - POTENTIAL SECURITY BREACH!
The server's host key does not match the one PuTTY has
cached in the registry. This means that either the
server administrator has changed the host key, or you
have actually connected to another computer pretending
to be the server.
The new rsa2 key fingerprint is:
ssh-rsa 2048 2e:78:ab:5f:96:c4:fb:07:6b:cd:04:a6:cc:1b:c5:93
If you were expecting this change and trust the new key,
enter "y" to update PuTTY's cache and continue connecting.
If you want to carry on connecting but without updating
the cache, enter "n".
If you want to abandon the connection completely, press
Return to cancel. Pressing Return is the ONLY guaranteed
safe choice.
Update cached key? (y/n, Return cancels connection)

-  в ответ на это нажмите Y на клавиатуре и далее клавишу ВВОД.
   После чего по экрану побегут строчки информации о процессе , 
   в это время ничего не предпринимайте дождитесь окончания загрузки, 
   после чего программа ssh_updater выйдет в основное меню, а прошиваемое устройство перезагрузится.