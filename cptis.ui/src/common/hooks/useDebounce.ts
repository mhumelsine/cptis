import { useRef, useCallback } from 'react';

function useDebounce<T extends (...args: any[]) => void>(callback: T | undefined, delay: number): T {
  const timer = useRef<ReturnType<typeof setTimeout> | null>(null);

  const debouncedFunction = useCallback((...args: Parameters<T>) => {
    if(!callback) return;
    
    if (timer.current) {
      clearTimeout(timer.current);
    }
    timer.current = setTimeout(() => {
      callback(...args);
    }, delay);
  }, [callback, delay]);

  return debouncedFunction as T;
}

export default useDebounce;