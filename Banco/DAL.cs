using ScreenSound.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenSound.Banco;
internal class DAL<T> where T : class
{
    protected readonly ScreenSoundContext context;

    public DAL(ScreenSoundContext context)
    {
        this.context = context;
    }

    public IEnumerable<T> ListContent()
    {
        return context.Set<T>().ToList();
    }
    public void AddContent(T target)
    {
        context.Set<T>().Add(target);
        context.SaveChanges();
    }
    public void UpdateContent(T target)
    {
        context.Set<T>().Update(target);
        context.SaveChanges();
    }
    public void DeleteContent(T target)
    {
        context.Set<T>().Remove(target);
        context.SaveChanges();
    }
    public T? RecoveryBy(Func<T, bool> condition)
    {
        return context.Set<T>().FirstOrDefault(condition);
    }
    public IEnumerable<T> ListBy(Func<T, bool> condition)
    {
        return context.Set<T>().Where(condition);
    }
}
