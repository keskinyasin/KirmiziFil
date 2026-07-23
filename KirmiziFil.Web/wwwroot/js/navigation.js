document.addEventListener('DOMContentLoaded', function () {
    const toggle = document.getElementById('navToggle');
    const menu = document.getElementById('navMenu');

    if (!toggle || !menu) return;

    const backdrop = document.createElement('div');
    backdrop.className = 'nav__backdrop';
    document.body.appendChild(backdrop);

    function openMenu() {
        menu.classList.add('is-open');
        backdrop.classList.add('is-open');
        toggle.setAttribute('aria-expanded', 'true');
        document.body.style.overflow = 'hidden';
    }

    function closeMenu() {
        menu.classList.remove('is-open');
        backdrop.classList.remove('is-open');
        toggle.setAttribute('aria-expanded', 'false');
        document.body.style.overflow = '';
    }

    toggle.addEventListener('click', function () {
        const isOpen = menu.classList.contains('is-open');
        isOpen ? closeMenu() : openMenu();
    });

    backdrop.addEventListener('click', closeMenu);

    menu.querySelectorAll('.nav__link').forEach(function (link) {
        link.addEventListener('click', closeMenu);
    });

    window.addEventListener('resize', function () {
        if (window.innerWidth >= 768) {
            closeMenu();
        }
    });
});