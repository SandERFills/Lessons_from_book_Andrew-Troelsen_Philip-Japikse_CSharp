using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalizableDisposableClass
{
    class MyResourseWrapper:IDisposable
    {
        private bool disposed = false;
        /// <summary>
        /// Пользователь объекта будет вызывать этот метод
        /// для как можно более скорой очистки ресурсов,
        /// </summary>
        public void Dispose()
        {
            // Очистить неуправляемые ресурсы.
            // Вызвать Dispose () для других освобождаемых объектов,
            // содержащихся внутри.
            CleanUp(true);
            // Если пользователь вызвал Dispose (), то финализация
            //не нужна, поэтому подавить ее.
            GC.SuppressFinalize(this);
        }
        /// <summary>
        /// Сборщик мусора вызовет этот метод,
        /// Если пользователь забыл вызвать метод Dispose()
        /// </summary>
        ~MyResourseWrapper()
        {
            Console.Beep();
            // Вызвать вспомогательный метод.
            // Указание false означает, что
            // очистку запустил сборщик мусора.
            CleanUp(false);
        }
        private void CleanUp(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {

                }
            }
            disposed = true;
        }
        
    }
}
